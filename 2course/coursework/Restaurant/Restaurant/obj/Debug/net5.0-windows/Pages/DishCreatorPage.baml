   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Restaurant
Restaurant  5           Restaurant.DishCreatorPage   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Restaurant     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� FontSize$  20(�5	   1   .��5      � $	��Top=�6   .+�5   
   �� .��5      ��  �� Orientation$ Vertical=�6   .+�5      � $��10q�6   .+�5      �� -   5         ��Name$ 
SaveButton��5   B   $��Зберегти��6   $
��Bold"�60   6V   5      �� 5      $��10q�6   $ Vertical=�6)   $��Center=�6@   .+�5      ��  �� 
IsReadOnly$
 True��6   $��
Назва��60   $
��Bold"�6=   $��Center=�6O   �� 5      -   5         ��Name$ DishName��5   8   $	��250��6   $
��25 0q�6*   $��Center=�6J   5      �� 5      $��10q�6   $ Vertical=�6)   $��Center=�6@   .+�5      �� $
 True��6   $(��"Ціна за порцію(грн)��60   $
��Bold"�6K   $��Center=�6]   �� 5      -   5        $ 	DishPrice��5   8   $	��250��6   $
��25 0q�6*   $��Center=�6K   5      �� 5      $��10q�6   $ Vertical=�6)   $��Center=�6@   .+�5      �� $
 True��6   $0��*Вага в одній порції(гр.)��60   $
��Bold"�6P   $��Center=�6b   �� 5      -   5        $ 
DishWeight��5   8   $	��250��6   $
��25 0q�6*   $��Center=�6L   5       �� 5"      $��10q�6   $ Vertical=�6)   $��Center=�6@   .+�5#      �� $
 True��6   $��Рецепт��60   $
��Bold"�6>   5%      �� 5'      $��Center=�6   $ 
Horizontal=�6:   .+�5(      �� -   5         ��Name$ IngredientList��5(   -   $
��50 0q�6    �� DisplayMemberPath$
 Name��5)       �� SelectedValuePath$
 Name��5*      $��100px��5+      5-      �� 5.      -   5        $ ReceptIngredientAdd��5.   @   $��Додати��6   $
��Bold"�6.   6]   5/      &   System.Windows.Controls.DataGrid  51      -   5          Name$ IngredientListDataGrid��51   )   $��18(�6   $��10q�6I   	   AutoGenerateColumns$	 False��6U   $
��Left=�6q   $
��Auto��6�   
   Columns
 52      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$' !Назва інгредієнта��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *Name+6a     56      $ Вага(гр)��6-      
IsReadOnly$ False��6?   $ 1* 6m    6R   �� *Weight+6m   4  .System.Windows.Controls.DataGridTemplateColumn  5?      $
 0.5* 61      CellTemplate 5@      �� 5A   "   .R�5B   &   �� -   5        $��Delete��5B   -   6>   5C   #   5E      5H      5J      5K      5M      5N      