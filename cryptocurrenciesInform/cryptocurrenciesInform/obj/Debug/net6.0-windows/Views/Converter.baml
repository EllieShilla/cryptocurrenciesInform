   M S B A M L   `   `   `  ????Q  McryptocurrenciesInform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:cryptocurrenciesInform.ViewscryptocurrenciesInform.Views  5      ,    &cryptocurrenciesInform.Views.Converter   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:cryptocurrenciesInform.Views     5        ? 	Resources  5	       	  Title ?? 
TargetType ?? Property ?? Value??%?   &	        ?? 5
   
   " ??6   .?5      ??  ? ??$ Medium"?6+   ?? 5       ? ??$ 40(?6)   ?? 5       ? ??$ Center=?64   ?? 5       ? ??$ 0 10 0 0q?6'   5      5      .??5      ]? 
???????.+?5   
   ? $??Center=?6    ? RowDefinitions 5      ?? 5      $	??100 ?6    ?? 5      $??28 ?6    ?? 5      $??28 ?6    ?? 5      $??28 ?6     ? ColumnDefinitions 5      ?? 5      $??1* ?6#   ?? 5      $??2* ?6#   ?? 5      $??* ?6#   ?? 5      $??2* ?6#   ?? 5      $??1* ?6#   .+?5!      ?? $??Cryptocurrency converter??6   $??3??5"      $??0??5#      $??1??6%   #??[  5$      ?? 5&      -   5        $??1??5&      $??1??6&   
?????????5(      ?? *Count+ ?? UpdateSourceTrigger$ PropertyChanged=?5)      ?? 5+      -   5        $
??from??5+      $??1??5,      $??2??6'   ??5+   #   ??  ?? Path$ ConvertCurrencies? ?? SelectedItem 5-      ?? *FromCurrency+??5.      ?? 5/      .R?50      ?? 	 ?? Orientation$	 
Horizontal=?6%   .+?51      ?? ??6(   ?? *name+52      53      55      ?? 57      -   5        $??to??57      $??2??58      $??3??6$   ??57   !   ?? $ ConvertCurrencies? 59      ?? *
ToCurrency+??5:      ?? 5;      .R?5<      ?? $	 
Horizontal=?6%   .+?5=      ?? ??6(   ?? *name+5>      5?      5A      ?? 5C      $??Convert??6   $??3??5D      $??3??6%   ??5E      ?? *	Convert+?? 5G      $??3??6   $??1??6&   
???????
 ?? 
IsReadOnly$

 True??5I      ??5J      ?? *Result+ ?? StringFormat$ {0:0.##}??5L      5M      5N      