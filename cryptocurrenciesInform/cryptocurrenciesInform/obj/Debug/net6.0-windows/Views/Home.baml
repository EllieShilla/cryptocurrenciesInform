   M S B A M L   `   `   `  ????Q  McryptocurrenciesInform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:cryptocurrenciesInform.ViewscryptocurrenciesInform.Views  5      U/clr-namespace:cryptocurrenciesInform.Converters!cryptocurrenciesInform.Converters  5      '    !cryptocurrenciesInform.Views.Home   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:cryptocurrenciesInform.Views     5      F
converters/clr-namespace:cryptocurrenciesInform.Converters     5        ? 	Resources  5
      ?   9cryptocurrenciesInform.Converters.IsMoreThenZeroConverter   IsMoreThenZeroConverter  
redOrGreen ?? 
TargetType ?? Property ?? Value ?? Triggers ?? Binding ?? 	Converter ?? Value  ListItemBorder  ListItemText  	ListLabel  ScrollViewer  	DockPanel??%5  &	        &	      7   &	 ?     &	 ?    &	     &	 ?    &	 N      5   
   6-   ?? 5   
   " ??6#   .?5      ??  ? ??
 ? ? ?6+    5      ?? 5       6   ?? *changePercent24Hr+8   	 false6x   .a?5      ??  ? ??
 ?  ??63   5      5      ?? 5   
   " ??6'   .?5      ??  ? ??$	 200??6&   ?? 5       ? ??$ 40??6'   ?? 5       ? ??
 ?????6,   ?? 5       ? ??$ 0,1,0,0q?60   5      ?? 5   
   " ??6%   .?5      ??  ?@??TextAlignment$ Center=?6.   ?? 5       ? ??$ 10q?6'   5      ?? 5   
   " ??6"   .?5      ??  ? ??$ Center=?64   ?? 5        ? ??$ Medium"?6+   5!      ?? 5"   
   " ??6%   .?5#      ??  ? ??$
 Auto=?6<   ?? 5$       ? ??$
 Auto=?6>   ?? 5%       ? ??$ Center=?6;   ?? 5&       ? ??
 ?????6+   5'      ?? 5(   
   " ]?6"   .?5)      ??  ? ??$ False??6.   ?? 5*       ? ??$ Center=?64   ?? 5+       ? ??$ 0 40 0 0q?6'   5,      5-      .??5/      ?? #??[ 6   .??50   
   ?? $??Center=?52      $	??800??66   ??50      ?? *
Currencies+ ?? SelectedItem 51      ?? *SelectedItem+??53      ?? 54      .R?55      ]? #??[ 6    .+?56      ? $	??Top=?6   $??30??64   	 ? ColumnDefinitions	 57      ?? 58   "   $	??200 ?63   6A   ?? 59   "   $	??200 ?63   6A   ?? 5:   "   $	??200 ?63   6A   ?? 5;   "   $	??200 ?63   6A   ?? 5<   "   $	??200 ?63   6A   ?? 5=   "   $	??200 ?63   6A   .+?5?      ?? $??0??6$   #??[ 64   .??6W   Name6]   ?? 5@      $??1??6$   #??[ 64   .??6W   Price6^   ?? 5A      $??2??6$   #??[ 64   .??6W   
24h Volume6c   ?? 5B      $??3??6$   #??[ 64   .??6W   
24h Change6c   5C      ?? 5D      6+   5E      5F      ??5H      ?? 5I      .R?5J      ?? 
 ?? Orientation$
 
Horizontal=?6!   .+?5K      ?? #??[ 6!   ._?5L      ?? #??[ 6(   ??5M   (   ?? *currencyName+5N      ?? 5O      #??[ 6!   ._?5P      ?? #??[ 6(   ??5Q   (   ?? *	rateUsd+ ?? StringFormat$
 ${0}??5R      ?? 5S      #??[ 6!   ._?5T      ?? #??[ 6(   ??5U   (   ?? *volumeUsd24Hr+$
 ${0}??5V      ?? 5W      #??[ 6!   ._?5X      ??  ??Name$ 	percent24??6(    ?? TextAlignment$ Center=?6;   $??10q?6R   #??[ 5Z   (   ??5Y   (   ?? *changePercent24Hr+$
 {0}%??5Z   (   5[      5\      5]      5_      5`      5a      