# Native SDK for .NET サンプル集
## 事前準備
### Git Clone

このリポジトリをGit Cloneします。

```
git clone https://github.com/Intersystems-jp/iris-dotnet-nativesdk-samples
```

### IRIS native SDKライブラリの設定

dotnet配下の各サンプルディレクトリにあるsamples.csprojファイルの内容を環境に合わせる


例えば、Windowsの一般的な環境では、

```
<ItemGroup>
    <Reference Include="InterSystems.Data.Utils">
      <HintPath>c:\Intersystems\iris\dev\dotnet\bin\net8.0\InterSystems.Data.Utils.dll</HintPath>
    </Reference>
    <Reference Include="InterSystems.Data.IRISClient">
      <HintPath>c:\Intersystems\iris\dev\dotnet\bin\net8.0\InterSystems.Data.IRISClient.dll</HintPath>
    </Reference>
  </ItemGroup>
```


### サンプル実行

#### dotnet¥PrintIRISVersion¥PrintIRISCersion.cs

稼働中のIRISバージョンを表示する

(ついでにSamples.ADBK.clsのロードも行う)

samples.csprojファイルをIDE（Visual StudioやVSCode）で開いて、ビルドして実行

#### dotnet¥adbk¥adbk.py

Samples.ADBKというクラスのインスタンスにアクセスするサンプル

samples.csprojファイルをIDE（Visual StudioやVSCode）で開いて、ビルドして実行

#### dotnet¥adbkglobal¥adbk-global.cs

Samples.ADBKというクラスのインスタンスにグローバルアクセスするサンプル

samples.csprojファイルをIDE（Visual StudioやVSCode）で開いて、ビルドして実行

#### dotnet¥adbkglobaliterator¥adbk-globaliterator.cs

Samples.ADBKというクラスのインスタンスにグローバルアクセスするサンプル

Iteratorを使用して繰り返し処理

samples.csprojファイルをIDE（Visual StudioやVSCode）で開いて、ビルドして実行

#### dotnet¥adbkdotnet¥adbk-ado.cs

ADO-NETを使用してSQLアクセスするサンプル

samples.csprojファイルをIDE（Visual StudioやVSCode）で開いて、ビルドして実行

