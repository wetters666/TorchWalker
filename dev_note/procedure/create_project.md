# 開発ルール・手順 - プロジェクトの作成

## プロジェクトの種類

- 2D(URP)で作成。
- 

## 基本アセット

- UniRx
    - Samplesは除外。

- Extenject Dependency Injection IOC
    - OptionalExtrasフォルダは除外。

この2つを入れた段階では特にエラー出ず。

次に下記の（★）の項目を実行後、とりあえずビルド。成功。

## トラブルシューティング・最初にやったことメモ

### プロジェクトのIDの設定

後述のセーブデータフォルダのパスとしても使用されるので最初に決めておいた方が楽。

- Company Name: 
- Product Name: TorchWalker

とした。

### 日本語がUnity Editor上で文字化けする（★）

スクリプトの作成時になぜか文字コードが「Shift-JIS」になることによる不具合。恐らくバグ。好ましくはUTF-8Nにしたい。

[このページ](https://github.com/sharkattack51/GarageKit_for_Unity/blob/master/UnityProject/Assets/__ProjectName__/Editor/AssetPostprocessUTF8Encode.cs)のスクリプトをコピーしてEditorフォルダに入れるとスクリプト生成時にUTF-8Nにしてくれる。

ここでは、materials/scriptsフォルダ下に作成した「AssetPostprocessUTF8Encode.cs」をTorchWalker/Editorフォルダ内にD&Dした。

### Visual Studio Editor Package version X.Y.Z is available…という警告が出る（★）

[このページ](https://baba-s.hatenablog.com/entry/2021/07/14/180000)を参照。

「Package Manager」→「In Project」→「Visual Studio」→「Upgrade to X.Y.Z」を押す。

プロジェクトごとに実行する必要がある。
