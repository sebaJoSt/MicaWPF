

<h1 align="center">MicaWPF</h1><br />
<div align="center"> 
<img src="./Logo/Logo178x178.png" width="256"/>
    </div>
<div align="center">
<h4>This is a library to make Mica available in WPF because we can't wait for WinUI 3.0 to support it in unpackaged apps.</h4>
    
[![License](https://img.shields.io/github/license/Simnico99/MicaWPF?style=flat)](https://github.com/Simnico99/MicaWPF/blob/main/LICENSE)
[![NuGet](https://img.shields.io/nuget/v/MicaWPF.svg?style=flat&logo=NuGet)](https://www.nuget.org/packages/MicaWPF/latest)
[![NuGet(preview)](https://img.shields.io/nuget/vpre/MicaWPF.svg?style=flat&logo=NuGet)](https://www.nuget.org/packages/MicaWPF/latest/prerelease)
[![NuGet(download)](https://img.shields.io/nuget/dt/MicaWPF.svg?style=flat&logo=NuGet)](https://www.nuget.org/packages/MicaWPF/)
[![CodeFactor](https://www.codefactor.io/repository/github/simnico99/micawpf/badge/main?style=flat&logo=codefactor)](https://www.codefactor.io/repository/github/simnico99/micawpf/overview/main)
</div>

<h2 align="center">Overview</h2>

### Installation
Download via the Nuget package manager.
```nuget
Install-Package MicaWPF
```

### Preview
![image](https://user-images.githubusercontent.com/80013536/139436431-fb3983d9-af4e-4d39-8bdf-b0f40093d263.png)<br/><br/>
Also snap grid works with this method:<br/>
![image](https://user-images.githubusercontent.com/80013536/139436498-ab330947-7df3-4c24-a382-3974ef554db2.png)

### Usage

### Recommended
The easiest way is to use the custom window:

1. In the code behind your window add those lines
```csharp
    public partial class MainWindow : MicaWindow //<-- Make this a mica window right here
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
```

2. In the window xaml add this:
```xaml
<mica:MicaWindow x:Class="WpfDemo.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfDemo"
        xmlns:mica="clr-namespace:MicaWPF.Controls;assembly=MicaWPF"
        mc:Ignorable="d"
        Title="MainWindow" 
        Height="450" 
        Width="800">
    <Grid>

    </Grid>
</mica:MicaWindow>

```

### Compatibility
If you already use a custom window you can do this:

1. In the code behind your window add those lines
```csharp
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded; //<-- Add this line
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e) //< --Add this entire method or add to your loaded method.
        {
            this.EnableMica(WindowsTheme.Auto); 
        }
    }
```

2. In the window xaml add this:
```xaml
<Window x:Class="WpfDemo.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfDemo"
        mc:Ignorable="d"
        Title="MainWindow" 
        Height="450" 
        Width="800"        
        Background="Transparent"> <!-- It's important to make it transparent -->
    <WindowChrome.WindowChrome> <!-- You can customise this section so it works well with your kind of app. -->
        <WindowChrome 
            CaptionHeight="20"
            ResizeBorderThickness="8"
            CornerRadius="0"
            GlassFrameThickness="-1"
            UseAeroCaptionButtons="True" />
    </WindowChrome.WindowChrome>
    <Grid>

    </Grid>
</Window>

```

### More Info
There is a demo app you can download in the demo folder if you need a template or to see it in action.
