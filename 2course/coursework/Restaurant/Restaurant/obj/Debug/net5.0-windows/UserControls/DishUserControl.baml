   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Restaurant
Restaurant  5           Restaurant.DishUserControl   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Restaurant     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $��650px��5	      $
��auto��6   $
��auto��6-     � 	Resources  5
         AddMenuButton �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius �� Triggers P� Property	 P� Value
 �� 
TargetName  MenuTextBox��%�  &	        &	 �    �� 5   
   " ��6&   .�5      ��  � ��
 �����6;   �� 5       � ��
 �   �6;   �� 5       � ��$ 15(�6)   66   �� 5       � ��$ Times New Roman)�6+   6E   �� 5       � ��$
 50px��6*   69   �� 5       � ��$ 100px��6)   69   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ Border��6!   $ 15��61   #��z��6C   $��1q�5   !   ._�5      �� $��Center=�6/   $��Center=�6L   5      5       5      P� 5       �@J�IsMouseOver$
	 True��6=   . �5   "   �� $
 Border��6R    � ��
 ����5      5       5"      5#      �� 5&   
   " ��6$   .�5'      ��  � ��
 �����6;   �� 5(       � ��
 �   �6;   �� 5)       � ��$ 15(�6)   66   �� 5*       � ��$ Times New Roman)�6+   6E   �� 5+       � ��$
 50px��6*   69   �� 5,       � ��$ 500px��6)   69   �� 5-       � �� 5.      �� 5/      " ��6&   .R�50      �� $ Border��6!   $ 15��61   #��z��6C   $��1q�51   !   ._�52      �� $��Center=�6/   $��Center=�6L   54      55      56      58      59      5<      .��5>      � -   5         �Name$ DishData��5>      $	��0 5q�6   
 � Tag$  ��6*   .+�5B   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide��5B   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration 0:0:0.8.��5C      �� ���#dde0e3$��2q�6*   $ 15��6>   ._�5F      �� $��10q�6    �� Orientation$ 
Horizontal=�6*   $��Bottom=�6C   .+�5I      �� -   5         ��Name$ 	DishImage��5I      $��300px��6/   $��200px��6=   $	��Top=�6L   $
��0 11q�6d   �� 5K      $ Vertical=�6!   .+�5L      �� -   5         ��Name$ DishName��5L   "    �� TextWrapping$
 Wrap=�5M   $    �� 
IsReadOnly$
 True��5N   $   $��300px��67   $I��CПаштет з ягідним джемом та крутонами��5O   $   $��Center=�5P   $   $��20(�5Q   $   $
��Bold"�63   $��5 0 0 0q�5R   $   �� 5T      -   5        $ DishIngredients��5T   "   $
��Left=�6;   $
 True��5U   "   $��300px��65   $��18(�5V   "   $��5 5 0 0q�60   $
 Wrap=�6A   $����Інгредієнти:
Паштет- 220г.
Крутони- 60 г.
Крутони- 60 г.
Крутони- 60 г.
Крутони- 60 г.��5W   "   �� 5Y      -   5        $ 	DishPrice��5Y   "   $
 True��5Z   "   $��Right=�5[   "   $��90UAH��5\   "   $��50(�6/   $��Cooper Black)�6=   ���	#FFC00000$��5 5 0 0q�5]   "   �� 5_      -   5        $��Видалити��5_   !   $��Right=�64   $��5q�6P   6[   5`      5c      5d      5e      5h      5i      