   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Restaurant
Restaurant  5   	       Restaurant.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Restaurant     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
Restaurant��5	   	   $	��600��6   $
��1024��6,   $
��1024��6<   $	��600��6I    � WindowStartupLocation$ CenterScreen=�6V      MaterialDesignFont#���   5
   	    � WindowStyle$
 None=�6<   .��5      � -   5        ���	#FFEEEEEE.+�5   
   �� $��	250 0 0 0q�6   $	��Top=�6(   .+�5      � ���	#FF0069C0$��15��6*   � 5      $��5q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�66   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$	 Cat=�6.   $
��30px��69   $
��30px��6F   �� 5      $��Black cat brewery��6    $��Center=�69   $��20(�6T   $��Champagne & Limousines)�6b   $
��Bold"�6�     5      $	 Cat=�6.   $
��30px��69   $
��30px��6F   5      �� 5      $ 
Horizontal=�6   $��Right=�66   $
��10 0q�6R   .+�5      �� -   5        $��30��5      $��30��6(   $��0q�6a   
���������64   Z� ��6J   Z� .��5        $ Minus=�62   5      �� 5      -   5        $��30��5      $��30��6(   $��0q�6a   
�������$��0 0 10 0q�6   ��64   Z� ��6J   Z� .��5        $ 
Fullscreen=�62   5      �� 5      -   5         ��Name$ ButtonFechar��5      $��30��63   $��30��6>   $��0q�6w   
���������6J   Z� ��6`   Z� .��5        $ Power=�62   5      5      5       5!      � 5$   
   $��
250 55 0 0q�6   .+�5%      � -   5         �Name$ GridPrincipal��5%      $��Center=�6*   .+�5&       � -   5          �Name$ 	MainFrame��5&       �� 	KeepAlive$ False��6+   6L   5'      5(      � 5+   
   $	��250��6   $
��Left=�6   ���	#FF222222.+�5-      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5        	  Name$	 TrainsitionigContentSlide��5-   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase
   OpeningEffect
 6U   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration 0:0:0.2.��5.      � -   5        $ 
GridCursor��5.      $��	0 100 0 0q�6+   ���	#FF0069C0$��10��6U   $
��Left=�6`   $��60��6{   $	��Top=�6�   5/      �� 51      -	   5         ��Name$ ListViewMenu��51      $��0 100q�6-   
�������$��Champagne & Limousines)�6S   $��18(�6{    �� SelectedIndex$ 0��6�   .@�53      �� $��60��6   .��54      �� $ 
Horizontal=�6!   .+�55        $
 Home=�62   $��30��6>   $��30��6I   $��Center=�6U   $��5q�6p   �� 56      $��Меню��6$   $��17(�60   $��Center=�6>   $
��20 0q�6Y   57      58      �� 5:      $��60��6   .��5;      �� $ 
Horizontal=�6!   .+�5<        $
 Food=�62   $��30��6>   $��30��6I   $��Center=�6U   $��5q�6p   �� 5=      $��Замовлення��6$   $��17(�66   $��Center=�6D   $
��20 0q�6_   5>      5?      �� 5A      $��60��6   .��5B      �� $ 
Horizontal=�6!   .+�5C        $ Pizza=�62   $��30��6?   $��30��6J   $��Center=�6V   $��5q�6q   �� 5D      $��Страви��6$   $��17(�62   $��Center=�6@   $
��20 0q�6[   5E      5F      �� 5H      $��60��6   .��5I      �� $ 
Horizontal=�6!   .+�5J        $ Chemist=�62   $��30��6A   $��30��6L   $��Center=�6X   $��5q�6s   �� 5K      $��Інгредієнти��6$   $��17(�67   $��Center=�6E   $
��20 0q�6`   5L      5M      5O      5Q      5T      5U      