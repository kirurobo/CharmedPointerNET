# CharmedPointer .NET
プレゼン時にカーソルを目立たせるアプリ

## 背景
プレゼンテーション時の画面キャプチャーで録画しようとすると、レーザーポインターは映りません。  
PowerPointでは Ctrl キーを押しながらドラッグで仮想ポインターを出す機能もありますが、知らない人が大半ですし、キーとマウス両方の操作が必要となります。

## 目標
そこでマウスを動かすだけでレーザーポインターの代わりとなるようにします。  
また、このソフトが動いていることを意識せずに利用できることを目指し、次の仕様としました。

## 仕様
- マウスを素早く動かすと目立つポインターが表示される。
- しばらく動かさないと消える。

## 類似ソフト
- OrangeMaker さんの [Kokomite](http://www.orangemaker.sakura.ne.jp/product/Kokomite/)
  ← ほぼ同内容なのですが、ボタンで ON/OFF の操作が必要でした。
- Arlaune さんの [Star Cursor](http://www.vector.co.jp/vpack/browse/person/an023869.html)
  ← マウスを動かすと絵が出るものですが、指し示す用途ではありませんでした。

## 動作環境
- Windows 7 以降
- .NET Framework 4

## インストール
リリースからダウンロードし、適当なフォルダに展開してください。

## アンインストール
フォルダごと削除してください。

## 使用方法
CharmedPointer を起動します。  
マウスを素早く降るなど、速めに動かすと円が現れます。

「タスクトレイに常駐」にチェックを付けると、ウィンドウを閉じても動作し続けます。

