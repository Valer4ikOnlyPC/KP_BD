   M S B A M L   `   `   `  ����A  =Keeper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Keeper.PagesKeeper.Pages  5          Keeper.Pages.PageOrder   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Keeper.Pages     5        N� Title$  	PageOrder��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��0.6* �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5    
   �� -   5         ��Name$	 Add��5       $��+��6   $��Stretch=�6*   $��Stretch=�6H   $��Center=�6d   $��Center=�6�   $��Normal"�6�   �� 5!   
   -   5        $ Delete��5!      $��-��6!   $��1��6-   $��Stretch=�6=   $��Stretch=�6[   $��Center=�6w   $��Center=�6�   $��Normal"�6�   �� 5"   
   -   5         ��Name$ CheckButton��5"      $��5��6)   $��Удалённые��69   ���	#FFE4E3E3$��Center=�6e   $��Center=�6�   $��14(�6�   
�������6�   �� 5#   
   -   5        $ 	AllDelete��5#      $	��⨉��6$   $��6��60   $��Stretch=�6@   $��Stretch=�6^   $��Center=�6z   $��Center=�6�   $y�	Collapsed=�6�   $
��Bold"�6�   �� 5%   
   -   5        $��ListViewOrder��5%      $��1��6(   $��8��65   $��9��6I   $��14(�6Z    �� View 5&      �� 5'      .P�5(      ��  �� Width$ 90��6Q    �� DisplayMemberBinding 6%   ��  �� Path$ Table�.��6\   
Стол6b   �� 5)      $ 90��6P    6%   �� $
 Time�.��6[   
Время6b   �� 5*      $	 120��6W    6%   �� $ OrderAmount�.��6c   Стоимость6n   �� 5+      $	 160��6W    6%   �� $ EmployeeSTR�.��6c   Сотрудник6n   �� 5,      $	 150��6R    6%   �� $ Status�.��6^   Статус6f   5-      5/      �� 50   
   -   5        	 ��Name$	 
AddControl��50      $��10��6-   $��10��6?   $y�	Collapsed=�6T   .��51      � ���	#B2121212.+�52      � $��Center=�6   $��Center=�64   ���	#FF252525.+�53      �� -   5        $��X��53      $��Right=�6)   $	��Top=�6E   $��12(�6r   �� 54      $��30q�6!   .+�55      �  56      �� 57   "   �� 58   "    5:      �� 5;   "   �� 5<   "   .+�5>      �� $��Стол��6$   $��0��63   $��0��6C   
�������6P   �� 5?      $��Сотрудник��6$   $��0��68   $��1��6H   
�������6U   �� 5@      -   5        
 ��Name$
 NumTable��5@   &   $��1��68   $��0��6H    �� SelectionBrush �	#FF616161
���   ����	#FFE0DFDF���	#FFE0DFDF6�   �� 5A      -	   5         ��Name$	 Emp��5A   '   $��1��64   $��1��6D   ���	#FF404040���	#FF131313���	#FF4040406�   5B      �� 5C      -
   5        $��Добавить��5C   !   $��60��64   $��20��6?   $��Stretch=�6K   $��1,1,1,1q�6g   $��0,5,0,0q�6y   $��12(�6�   5D      5E      5F      5G      5H      5I      