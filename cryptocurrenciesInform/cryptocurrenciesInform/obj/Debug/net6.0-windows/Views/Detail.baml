   M S B A M L   `   `   `  ????Q  McryptocurrenciesInform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:cryptocurrenciesInform.ViewscryptocurrenciesInform.Views  5      U/clr-namespace:cryptocurrenciesInform.Converters!cryptocurrenciesInform.Converters  5      )    #cryptocurrenciesInform.Views.Detail   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:cryptocurrenciesInform.Views     5      F
converters/clr-namespace:cryptocurrenciesInform.Converters     5        ? 	Resources  5      ?   9cryptocurrenciesInform.Converters.IsMoreThenZeroConverter   MoreThenZeroConverter  ListBoxLabel ?? 
TargetType ?? Property ?? Value  ListBoxItemTemplate  ScrollViewer  CryptoLabel  MainGrid  BorderTitle 	 Title  
CryptoInfo 	 ListBoxBorder??%?  &	        &	      &	 ?     &	     &	 ?    &	 4    &	 ?    &	     &	 ?    &		 ?      5   
   6-   ?? 5   
   " ??6%   .?5      ??  ? ??$ Center=?64   ?? 5       ? ??$ Medium"?6+   5      ?? 5   
   " ??6,   .?5      ??  ?@??TextAlignment$ Center=?6.   ?? 5       ? ??$ 10q?6'   5      ?? 5   
   " ??6%   .?5      ??  ? ??$
 Auto=?6<   ?? 5       ? ??$
 Auto=?6>   ?? 5       ? ??$ Center=?6;   5      ?? 5   
   " ??6$   .?5      ??  ? ??$ Medium"?6+   ?? 5       ? ??$ Right=?64   ?? 5       ? ??$ 14(?6)   5      ?? 5   
   " ?6!   .?5       ??  ? ??
 ?????6+   ?? 5!       ? ??$ Center=?64   5"      ?? 5#   
   " ??6$   .?5$      ??  ? ??
 ?????6,   ?? 5%       ? ??$ 0,0,0,1q?60   5&      ?? 5'   
   " ??6   .?5(      ??  ?@??TextAlignment$ Center=?6.   ?? 5)       ? ??$ 10q?6'   ?? 5*       ? ??$ 30(?6)   ?? 5+       ? ??$
 Wrap=?6-   5,      ?? 5-   
   " ??6#   .?5.      ??  ? ??$
 Left=?64   ?? 5/       ? ??$ 16(?6)   ?? 50       ? ??$ 10 0 0 0q?6'   ?? 51       ?@??Padding$ 0 4 0 0q?6(   52      ?? 53   
   " ??6&   .?54      ??  ? ??$	 200??6&   ?? 55       ? ??$ 40??6'   ?? 56       ? ??
 ?????6,   ?? 57       ? ??$ 0,1,0,0q?60   58      59      .??5;      ? #??[ 6    ? ColumnDefinitions 5<   
   ?? 5=      $??1* ?6   6,   ?? 5>      $??2* ?6   6,   .+?5@   
   ? $??0??6   $??20 40q?6    ? RowDefinitions 5A      ?? 5B      $	??100 ?6    6/   ?? 5C      $??40 ?6    6.   ?? 5D      $??40 ?6    6.   ?? 5E      $??40 ?6    6.   ?? 5F      $??40 ?6    6.   ?? 5G      $??40 ?6    6.   ?? 5H      $??40 ?6    6.    5J      ?? 5K      $??* ?6#   6/   ?? 5L      $??* ?6#   6/   .+?5N      ?? $??0??6   $??2??6"   #??[ 66   ._?5O      ?? #??[ 6   ??6;   ?? *_Asset.name+5P      ?? 5Q      $??1??6   $??0??6!   #??[ 61   .??6V   Price:6^   ?? 5R      $??2??6   $??0??6!   #??[ 61   .??6V   24h Volume:6c   ?? 5S      $??3??6   $??0??6!   #??[ 61   .??6V   
Change 1h:6b   ?? 5T      $??4??6   $??0??6!   #??[ 61   .??6V   Change 24h:6c   ?? 5U      $??5??6   $??0??6!   #??[ 61   .??6V   
Change 7d:6b   ?? 5W      $??1??6   $??1??6"   ._?5X      ?? #??[ 6   ??6@   ?? *_Asset.price+ ?? StringFormat$ 
$ {0:0.##}??5Y      ?? 5Z      $??2??6   $??1??6"   ._?5[      ?? #??[ 6   ??6@   ?? *_Asset.volume_24h+$ 
$ {0:0.##}??5\      ?? 5]      $??3??6   $??1??6"   ._?5^      ?? $
??Left=?6   $??16(?5_       ?? Padding$ 0 4 0 0q?5`      $??10 0 0 0q?5a      ??5b      ?? *_Asset.change_1h+$ 	{0:0.##}%????5c      ?? 5d      " ??6    .?5e      ??  ? ??
 ? ? ?6;    ?? Triggers 5f      ?? 5g   "   	 ?? Binding	 6.   ?? *_Asset.change_1h+
 ?? 	Converter#
 [   ?? Value	 false6?   .a?5h   &   ??  ? ??
 ?  ??6C   5i   #   5k      5m      5n      ?? 5o      $??4??6   $??1??6"   ._?5p      ?? $
??Left=?6   $??16(?5q      $ 0 4 0 0q?5r      $??10 0 0 0q?5s      ??5t      ?? *_Asset.change_24h+$ 	{0:0.##}%????5u      ?? 5v      " ??6    .?5w      ??  ? ??
 ? ? ?6;    5x      ?? 5y   "   	 6.   ?? *_Asset.change_24h+#
 [  	 false6?   .a?5z   &   ??  ? ??
 ?  ??6C   5{   #   5}      5      5?      ?? 5?      $??5??6   $??1??6"   ._?5?      ?? $
??Left=?6   $??16(?5?      $ 0 4 0 0q?5?      $??10 0 0 0q?5?      ??5?      ?? *_Asset.change_7d+$ 	{0:0.##}%????5?      ?? 5?      " ??6    .?5?      ??  ? ??
 ? ? ?6;    5?      ?? 5?   "   	 6.   ?? *_Asset.change_7d+#
 [  	 false6?   .a?5?   &   ??  ? ??
 ?  ??6C   5?   #   5?      5?      5?      5?      ? 5?   
   $??1??6   $??20 40q?6   .+?5?      ?? #??[ 6   .??5?      ?? ??6   ?? *	Markets+??5?      ?? 5?      " ??6    .?5?      ??  ? ??$ Stretch=?6K   5?      ??5?      ?? 5?      .R?5?      ]? $??False??6(   .+?5?   "   ? $	??Top=?6'   $??30??6<    5?   &   ?? 5?   *   $	??200 ?6;   6I   ?? 5?   *   $	??200 ?6;   6I   ?? 5?   *   $	??200 ?6;   6I   .+?5?   &   ?? $??0??6,   #??[ 6<   .??6b   Title6i   ?? 5?   &   $??1??6,   #??[ 6<   .??6b   Price (USD)6o   ?? 5?   &   $??2??6,   #??[ 6<   .??6b   
Currency6l   5?   #   ?? 5?   "   63   5?      5?      ??5?      ?? 5?      .R?5?      ??  ?? Orientation$ 
Horizontal=?6)   .+?5?   "   ?? #??[	 6)   ._?5?   &   ?? #??[ 60   ??6]   ?? *
exchangeId+5?   #   ?? 5?   "   #??[	 6)   ._?5?   &   ?? #??[ 60   ??6]   ?? *
priceUsd+$ 	${0:0.##}??5?   #   ?? 5?   "   #??[	 6)   ._?5?   &   ?? #??[ 60   ??6]   ?? *	quoteId+5?   #   5?      5?      5?      5?      5?      5?      5?      