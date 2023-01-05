# 開発ルール・手順 - ピクセルパーフェクトカメラおよび固定解像度

## 基本的な流れ

##### 画面の解像度を決める

ここでは480x270（FullHDの1/4）として話を進める。

##### PPU(1mが何ピクセルか)を決める

ここではPPU=100として話を進める。

##### テクスチャアセットの設定

###### Pixels Per Unit

- Texture Typeを「Sprite(2D and UI)」にする
- Sprite Modeの「Pixels Per Unit」を100(PPU)に設定。
- 標準では1m = 100ピクセルになっている。

###### Filter Modeを線形補間しない設定に

- AdvancedのFilter Modeを「Point(no filter)」にする。

###### Pivotを「Bottom」に（オプション）

- ドット絵の2Dのゲームの場合、上下があるゲームの場合は下を基準点に、上下がないパズルゲームなどの場合は左上を基準点にするのが良さそう。
- ここでは下中央（Bottom）を基準点で統一する。

##### メインカメラへのPixel Perfect Cameraのアタッチ

- 2D(URP)を使用すると、ピクセルパーフェクトカメラは最初から使えるようになっている。
- Add ComponentでPixel Perfect Cameraを探してアタッチする。
    - 2つあって、片方はURP用ではない。警告が出ない方をアタッチする。
- Assets Pixels Per Unitを100(PPU)に設定。
- Reference Resolutionを480x270(決めた値)に設定。

## スプライトの配置

##### 特定の位置（ピクセル）に配置



## 使い方メモ