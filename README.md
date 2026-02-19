# Avalonia Splash Screen Template

Template de projeto Avalonia com Splash Screen animada e arquitetura MVVM.

## Instalação local

```bash
dotnet new install ./AvaloniaSplashScreen.Template
```

## Uso

```bash
dotnet new avalonia-splash -n MeuProjeto
```

Ou pelo Visual Studio: **Criar novo projeto** → pesquise por **"Avalonia Splash"**.

## Estrutura gerada

```
MeuProjeto/
├── Assets/
│   ├── icon.ico          ← substitua pelo seu ícone
│   └── splash.png        ← substitua pela sua imagem
├── Views/
│   ├── SplashWindow.axaml(.cs)
│   └── MainWindow.axaml(.cs)
├── ViewModels/
│   ├── ViewModelBase.cs
│   └── MainWindowViewModel.cs
├── App.axaml(.cs)
├── Program.cs
├── app.manifest
└── MeuProjeto.csproj
```

## Personalização

- **Splash Screen**: troque `Assets/splash.png` e ajuste o tempo em `SplashWindow.axaml.cs` no método `DummyLoad()`
- **Lógica de inicialização**: substitua os `Task.Delay` por sua inicialização real (carregar configs, conectar BD, etc.)
- **Framework**: ao criar o projeto, use `--framework net8.0` para .NET 8

## Desinstalar

```bash
dotnet new uninstall AvaloniaSplashScreen.Template
```
