   M S B A M L   `   `   `  ����A  =Keeper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KeeperKeeper  5   	       Keeper.WindowDialog   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Keeper     5   	     � Title$!  Закрытие кассы��5   	    � SizeToContent$ WidthAndHeight=�6     � WindowStartupLocation$ CenterScreen=�6?    � 
ResizeMode$ NoResize=�6d   .��5	      � $��10q�6   .+�5
   
   �� .@�5      �� $	�� ? ��6   
�������.��5      �  � RowDefinitions 5      �� 5      $��20 �6(   �� 5      $
��Auto �6(   .+�5      �� DBВы уверены что хотите закрыть кассу?6F   � 5      $��2��6    $��0,10,0,0q�6.   $��Center=�6@   .+�5      �� -   5         �� 	IsDefault$
 True��5   !   $��60��62   $��0,0,10,0q�6@   $��12(�6g   
���   ����	#FFE6E5E5
�������.��6�   Да6�   �� 5       �� IsCancel$
 True��6!   $��60��61   $��12(�6?   
���   ����	#FFE6E5E5
�������.��6�   Нет6�   5      5      5      �� 5      $)��#Посмотреть выручку��6   
�������.��5      �  5      �� 5      $��50 �6(   �� 5      $��50 �6(   �� 5      $��50 �6(   .+�5       �� -   5        $��ListViewRevenue��5       $��0��66   $��2��6C   $��6��6W   $��14(�6h   
���   �
�������
������� �� View 5!      �� 5"      .P�5#   "   ��  �� Width$	 120��6e   	 �� DisplayMemberBinding	 61   �� 
 �� Path$
 RevenueAmount�.��6q   Сумма выручки6�   �� 5$   "   $	 100��6d   	 61   �� $
 RevenueRatio�.��6p   Коэффициент6}   �� 5%   "   $ 78��6\   	 61   �� $

 Date�.��6g   
Дата6m   5&      5(      5)      5*      5+      5-      5.      