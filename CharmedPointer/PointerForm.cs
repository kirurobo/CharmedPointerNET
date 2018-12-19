using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CharmedPointer
{
    public partial class PointerForm : Form
    {
        /// <summary>
        /// 座標の基準点
        /// デフォルトは中央
        /// </summary>
        public System.Drawing.Point Origin;

        public Rectangle SlideWindowRectangle;
        public Rectangle PreviewWindowRectangle;
        public bool HasPreview;
        public bool IsEnabled = true;

        /// <summary>
        /// 期間内にこの平均速度 [px/s] を超えるとポインターを表示する
        /// </summary>
        public double showVelocityThreshold = 1500.0;

        /// <summary>
        /// 一度表示されたあとはこの平均速度 [px/s] を超える限りポインターを表示する
        /// </summary>
        public double hideVelocityThreshold = 20.0;

        /// <summary>
        /// 一度表示されたら、この時間 [s] 表示し続ける
        /// </summary>
        public double ShowDuration = 2.0;

        private int MaxVelocityQueue;
        private readonly double QueueDuration = 0.3;        // マウス速度を観察する期間 [s]
        private Point lastMousePosition = Point.Empty;
        private bool isVisible = false;

        private Stopwatch stopwatch = new Stopwatch();
        private long lastElapsedMilliseconds = 0;
        private long lastShownMilliseconds = 0;

        /// <summary>
        /// 一定期間のマウス速度を保持するためのキュー
        /// </summary>
        private Queue<double> velocities;


        public PointerForm()
        {
            InitializeComponent();

            Initialize();    // 独自要素の初期化
        }

        private void Initialize()
        {
            Origin = new Point(Width / 2, Height / 2);

            // マウス速度を観察するキューの個数を、観察時間[s]とタイマー間隔[ms]から決める
            MaxVelocityQueue = (int)(QueueDuration * 1000.0 / timerForMainLoop.Interval);

            velocities = new Queue<double>(MaxVelocityQueue);
        }

        /// <summary>
        /// 起動後の初期化処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PointerForm_Load(object sender, EventArgs e)
        {
            // 最後に調べたマウス座標を初期化
            lastMousePosition = Control.MousePosition;

            // 時刻計測開始
            stopwatch.Start();
            lastElapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            // メインループ開始
            timerForMainLoop.Start();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var createParams = base.CreateParams;
                createParams.ExStyle |= 0x00000020;     // WS_EX_TRANSPARENT を追加
                createParams.ExStyle |= 0x00000008;     // WS_EX_TOPMOST を追加
                return createParams;
            }
        }

        protected override bool ShowWithoutActivation => true;

        public void Begin()
        {

        }

        public void End()
        {

        }

        /// <summary>
        /// 画面上での座標を設定
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void SetPosition(float x, float y)
        {
            Left = (int)x - Origin.X;
            Top = (int)y - Origin.Y;
        }

        /// <summary>
        /// 画面上での座標を設定
        /// </summary>
        /// <param name="position"></param>
        public void SetPosition(Point position)
        {
            SetPosition(position.X, position.Y);
        }

        /// <summary>
        /// 一定周期での呼び出し
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerForMainLoop_Tick(object sender, EventArgs e)
        {
            UpdateAverageVelocity();
            UpdatePointer();

            if (CheckVisiblity())
            {
                if (!isVisible)
                {
                    Show();
                    isVisible = true;
                }
            }
            else
            {
                if (isVisible)
                {
                    Hide();
                    isVisible = false;
                }
            }
        }

        /// <summary>
        /// 表示すべきか否かを検査して返す
        /// </summary>
        /// <returns></returns>
        private bool CheckVisiblity()
        {
            if (!IsEnabled) return false;

            long now = stopwatch.ElapsedMilliseconds;

            if (!isVisible)
            {
                // 平均速度がしきい値以上なら表示開始
                if (velocities.Average() >= showVelocityThreshold)
                {
                    lastShownMilliseconds = now;
                    return true;
                }
            }
            else
            {
                if ((now - lastShownMilliseconds) <= (long)(ShowDuration * 1000))
                {
                    return true;
                }
                if (velocities.Average() >= hideVelocityThreshold)
                {
                    lastShownMilliseconds = now;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 平均速度の記録を更新
        /// </summary>
        private void UpdateAverageVelocity()
        {
            var pos = Control.MousePosition;

            long now = stopwatch.ElapsedMilliseconds;
            double deltaTime = (now - lastElapsedMilliseconds) / 1000.0;
            int dx = pos.X - lastMousePosition.X;
            int dy = pos.Y - lastMousePosition.Y;
            double velocity = Math.Sqrt(dx * dx + dy * dy) / deltaTime;

            // 規定数以上の分がキューにもしあれば削除
            while (velocities.Count >= MaxVelocityQueue)
            {
                velocities.Dequeue();
            }

            // キューに追加
            velocities.Enqueue(velocity);

            lastElapsedMilliseconds = now;
            lastMousePosition = pos;
        }

        /// <summary>
        /// ポインター座標の更新
        /// </summary>
        private void UpdatePointer()
        {
            var pos = Control.MousePosition;

            // もしPowerPointのプレビューがあった場合
            if (HasPreview)
            {
                // スライショー領域にマウスがなく、かつ、プレビュー領域にあれば、座標を変換
                if (!SlideWindowRectangle.Contains(pos) && PreviewWindowRectangle.Contains(pos))
                {
                    int px = PreviewWindowRectangle.X;
                    int py = PreviewWindowRectangle.Y;
                    Point newPos = new Point(
                        (pos.X - px) * SlideWindowRectangle.Width / PreviewWindowRectangle.Width + SlideWindowRectangle.X,
                        (pos.Y - py) * SlideWindowRectangle.Height / PreviewWindowRectangle.Height + SlideWindowRectangle.Y
                        );
                    pos = newPos;
                }
            }

            SetPosition(pos);
        }

        private void PointerForm_Shown(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
