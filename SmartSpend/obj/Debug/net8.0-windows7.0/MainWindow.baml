   M S B A M L   `   `   `  ����[  WLiveChartsCore.SkiaSharpView.WPF, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null}Xclr-namespace:LiveChartsCore.SkiaSharpView.WPF;assembly=LiveChartsCore.SkiaSharpView.WPF LiveChartsCore.SkiaSharpView.WPF  5   	    
SmartSpend   SmartSpend.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   hlvcXclr-namespace:LiveChartsCore.SkiaSharpView.WPF;assembly=LiveChartsCore.SkiaSharpView.WPF     5   	   -   5        $
��1000��5   	   $	��800��6     � WindowStartupLocation$  CenterScreen=�6#    � WindowStyle$
 None=�5	   	   
�������.��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��300 �6   �� 5      $��80 �6   �� 5      $��* �6   .+�5   
   �� -   5        $��X��5      $��0��6   $��40��6*   $��40��65   $��Right=�5      $	��Top=�6-   $��5q�6F   
������ 
������ 
���  ��$��25(�5   "   $
��Bold"�60   /   )LiveChartsCore.SkiaSharpView.WPF.PieChart  5   
   -   5        $��ExpensesChart��5      $��1��6,   ,   &LiveChartsCore.SkiaSharpView.WPF.Chart   LegendPosition$ Right=�6V      Series 69   �� *	PieSeries+6V   �� 5   
   -   5        $��Add expenses��5      $��2��6(   $	��200��65   $��60��6A   
�����@�$��22(�5   ;   �� 5   
   -   5        $��ExpensesList��5      $��3��6&   $��18(�6U   $��Stretch=�6c   
������ 
���������63   �� *	ListItems+��5       �� 5!      .R�5"      �� $��2q�6   
�������
���   � �� CornerRadius$ 5��6]    �� Padding$ 10q�6n   $��5q�6{   $��Stretch=�5#      ._�5$      �  � ColumnDefinitions 5%      �� 5&   "   $��* �63   �� 5'   "   $
��Auto �63   �� 5(   "   $��60 �63   .+�5*      �� $��0��6(   $��SemiBold"�6I   ��68   �� 6I   �� 5+      $��DeleteExpenseBtn��6%   -   5        $��2��5+   \   
������ 
������ 
���  ��$��25(�5-   6   $
��Bold"�6D   .��6V   X6Y   5.      5/      50      52      54      57      