# 開発ルール・手順 - 公開セーブ

## 公開セーブとは？

ユーザのローカルに保存する、ユーザによる改ざんをそれほど気にしないセーブデータを指す。

ソシャゲでもない限り改ざんされてもそれほど問題にはならないし、セーブデータの内容を容易に確認できたほうがむしろ開発しやすいので
基本的に公開セーブ方式でセーブデータを扱う。

ここではWindowsを想定する。WebGL、Android、iOSなどの場合はそれぞれデバイスごとの注意が必要。

## PersistentDataPath

Unityが用意するファイルパスはいくつもあり、Application.xxxxPathでアクセスすることができる。

（C#の機能を使用する場合はこれで取得できるパス以外にも保存可能だが、これらを使う方が安全）

結論としてはPersistentDataPathを使うが、他のフォルダについても触れておく。

##### dataPath

- /Assets 下を指す。開発中はプロジェクトフォルダ内のAssetsフォルダ、公開後はビルドしたフォルダ内に作られるAssetsフォルダとなる。
- 開発中と公開後で場所が変わり、Unity管理下に入るのが気持ち悪いため使用しない。

##### streamingAssetsPath

- /Assets/StreamingAssets 下を指す。
- Asset Bundleの仕組みを使うのに使うべきらしい。dataPathと同じくUnity管理下に入るのが気持ち悪いため使用しない。

##### PersistentDataPath

- User/AppData/LocalLow/CompanyName/ProductName 下を指す。
- Unity管理外・ゲームフォルダ外となる。
- 同ゲームを2つ起動するとおかしいことになる。

## persistentDataPath内にテキストファイルを保存（JSONUtilityの例）

.NET の標準ライブラリで保存・読み込みを行う。

##### 参考ページ

- [persistentDataPath で指定された Unity 推奨のフォルダパスにデータを書き込む](https://sorceryforce.net/ja/tips/unity-file-persistent-data-path)

## XML形式で保存

C#の標準的な機能で階層構造ありのデータを保存する場合、JSONよりもXMLを使う場合が多いようだ。

オブジェクトをXMLファイルとして入出力する方法として.NETのXmlSerializerが提供されている。

他にもXDocumentとかあり、Linqが使えたりしてそちらの方が使いこなせれば強そうだが、以下の参考ページが分かりやすかったのと
単純なデータであればデータ構造が一番分かりやすそうだったので、ひとまずXmlSerializerを使うことにする。

##### 参考ページ

- [【C#】オブジェクトの内容をXMLへ書き出す・読みこむ](https://takap-tech.com/entry/2017/06/22/225341)
- [System.Xml.Serialization.XmlSerializerで色々なXMLをデシリアライズするサンプル](https://zenn.dev/ail/articles/41127d2fad1c80)

## スクリプトからセーブファイルのパスを開く

以下のページを参照のこと。

- [【Unity】 セーブファイルのパスを開くメニューを作る](https://www.urablog.xyz/entry/2021/11/05/070000)

Unityエディタ上から実行するためのスクリプトとして、TorchWalker/Scripts/Editor/OpenSaveFolder.csにエディタスクリプトを追加した。
