   M S B A M L   `   `   `  ????@  <Week4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Week4Week4  5   	       Week4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Week4     5   	   -   5          ? Icon$  relaxed.ico??5   	    ? Title$" Introduction to Data Binding??5	   	   $	??450??6.   $	??800??6;    ? 	Resources 5
      (  "Week4.CreditsToPercentageConverter   percentConverter'  !Week4.RelativeToAbsoluteConverter  absoluteConverter??%:   &	        &	        5   
   6-     5   
   6,   5      .??5      ?? .+?5   
   ?? $??30(?6'   $??69??65   $	??262??6A    J? RenderTransformOrigin$ 1,0.851&?6M    ?? Left$ 33??6m   
 ?? Top$ 24??6~   ??6   ?? *ID+6~   ?? 5   
   $??30(?6-   $ 33??6;   $	 109??6L   $??67??6]   $	??286??6i   $ -0.194,0.498&?6u   ??6   ?? *
Fullname+6u   ?? 5   
   -   5        $??Calculate_Age??5      $ 4.918,5.205&?6>   $??67??6b   $??74??6n   $	 361??6y   $	 273??6?   ? 5   
    ? Minimum$ 0Q?5       ? Maximum$	 130Q?6"   $	??306??5      $??47??6"   $	 258??6.   $	 202??6@    ? Value 5      ?? *	Credits+5   @   ?? 5   
   $	??175??6   $	 485??6    $	 174??62   $??25??6C   ?? 5      $??20(?6+   ?6   ?? *	Credits+6+    - ?? 5      $??20(?60   ?6   ?? *TotalCredits+60   5      ?? 5   
   $??20(?6Y   $	 324??6g   $	 172??6y   $	??161??6?   $ 0.653,0.367&?6?   ??6   ?? *	Credits+	 ?? 	Converter#	 [  6?   ?? 5   
   ??5      ?? 5      
 ?? ImageSource
 6   ?? *
AvatarPath+#	 [  J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5       5"      ?? 5#   
   $	??187??6[   $??89??6g   $ 1.901,0.945&?6s   $	 338??6?   $ 20??6?   ??6   ?? *
AvatarPath+#	 [ z?5$      V? 5%      .~?5&      ?? ?? 5'       ?? AngleY$ 0.043Q?6$   ?? 5(      T? 5)       T? Y$ 2.393Q?6)   5*      5,      5-      5.      