   M S B A M L   `   `   `  ����E  ASmartSpend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SmartSpend
SmartSpend  5   	       SmartSpend.AddExpense   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SmartSpend     5   	   -   5          � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterScreen=�6   $	��600��5	   
   $	��600��6   
�������.��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� -   5        $��X��5      $��0��6   $��40��6*   $��40��65   $��Right=�5      $	��Top=�6-   $��7q�6F   
������ 
������ 
���  ��$��25(�5   "   $
��Bold"�60   �� 5   
   -   5        $��CategoriesBox��5      $��1��6*   $	��400��68   $��70��6D   $��20(�5   G   $��Center=�5      $��Center=�67   ��5   P   �� *
Categories+5      �� 5   
   -   5        $��SubcategoriesBox��5      $��2��6-   $	��400��6;   $��70��6G   $��20(�5       $��Center=�6#   $��Center=�6E   ��5   J   �� *Subcategories+5!      �� 5"   
   -   5        $��ExpensesValueTextBox��5"      $��Center=�6G   $��3��6e    �� TextWrapping$
 Wrap=�6r   $��Center=�6�   $	��400��6�   $��70��5#      $��25(�6   $��Center=�6,   $��Center=�6N   �� 5$   
   -   5        $��AddExpenseButton��5$      $��4��6)   $	��200��66   $	��100��6B   $	��Add��6O   $��25(�6}   
�����@�5%      5)      5*      