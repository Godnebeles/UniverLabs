   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Restaurant
Restaurant  5      "    Restaurant.OrdersUserControl   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Restaurant     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $��650px��5	      $
��auto��6   $
��auto��6-   .��5      � -   5          �Name$  DishCountData��5      $	��0 5q�6"   
 � Tag$  ��6/   .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration 0:0:0.8.��5      �� ���#dde0e3$��2q�6*    �� CornerRadius$ 15��6>   ._�5      �� $��10q�6    �� Orientation$ 
Horizontal=�6*   $��Bottom=�6C   .+�5      �� -   5         ��Name$ 	DishImage��5      $��300px��6/   $��200px��6=   $	��Top=�6L   $
��0 11q�6d   �� 5      $ Vertical=�6!   .+�5      �� -   5         ��Name$ DishName��5   "   	 �� TextWrapping$
	 Wrap=�5   $   
 �� 
IsReadOnly$

 True��5   $   $��300px��67   $I��CПаштет з ягідним джемом та крутонами��5   $   $��Center=�5   $   $��20(�5   $   $
��Bold"�63   $��5 0 0 0q�5    $   �� 5"      -   5        $ DishIngredients��5"   "   $
��Left=�6;   $

 True��5#   "   $��300px��65   $��18(�5$   "   $��5 5 0 0q�60   $
	 Wrap=�6A   $����Інгредієнти:
Паштет- 220г.
Крутони- 60 г.
Крутони- 60 г.
Крутони- 60 г.
Крутони- 60 г.��5%   "   �� 5'      -   5        $ 	DishPrice��5'   "   $

 True��5(   "   $��Right=�5)   "   $��90UAH��5*   "   $��50(�6/   $��Cooper Black)�6=   ���	#FFC00000$��5 5 0 0q�5+   "   �� 5-      -   5        $ CookDate��5-   "   $��Right=�64   $

 True��5.   "   $��18(�5/   "   $��5 5 0 0q�60   $
	 Wrap=�6A   $  ��6U   �� 51      -   5        $ 	DishCount��51   "   $��Right=�65   $

 True��52   "   $��18(�53   "   $��5 5 0 0q�60   $
	 Wrap=�6A   �� 56      $��Right=�6%   $ 
Horizontal=�6B   .+�57      �� -	   5        $��Відміна��57   %   $��5q�6R   �� 58      -
   5        $��Виконано��58   %   $��5q�6S   59      5;      5>      5?      5@      5C      5D      