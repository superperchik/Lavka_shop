   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.BuyPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  BuyPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��184* �6   �� 5      $
��217* �6   �� 5      $
��208* �6   �� 5      $
��191* �6   .+�5   
   �� $��Название��6   $��20(�6$   $��1��62   $��1��6?   $��Center=�6O   $��Center=�6l   $��26��6�   $	��165��6�   6�   �� 5   
   -   5         ��Name$ namedata��5      $��1��6:   $��1��6G   $��2��6W   $��217,22.667,0.333,22.667q�6k   ��6$   �� *name+6k   �� 5   
   $��Описание��6   $��20(�6$   $��2��62   $��1��6?   $��Center=�6O   $��Center=�6l   $��27��6�   $��67,24.333,67.333,23.333q�6�   $��83��6�   6�   �� 5   
   -   5        $ description��5      $��2��6D   $��1��6Q   $��2��6a   $��217,22.333,0.333,23.333q�6u   ��6'   �� *description+6u   �� 5    
   $��Количество��6    �� TextAlignment$ Center=�6&   $��20(�6=   $��3��6K   $��1��6X   $��Center=�6h   $��Center=�6�   $��27��6�   $	��156��6�   6�   �� 5!   
   -   5        $ count��5!      $��3��68   $��1��6E   $��2��6U   $��217,21.667,0.333,23q�6i   ��6!   �� *count+6i   �� 5"   
   $��Состояние��6   $ Center=�6%   $��20(�6<   $��4��6J   $��1��6W   $��Center=�6g   $��Center=�6�   $��26��6�   $	��156��6�   6�   �� 5#   
   -   5        $ 	condition��5#      $��4��6@   $��1��6M   $��2��6]   $��217,22,0.333,22.333q�6q   ��6%   �� *	condition+6q   �� 5$   
   $��Стоимость��6   $ Center=�6%   $��20(�6<   $��5��6J   $��1��6W   $��Center=�6g   $��Center=�6�   $��26��6�   $	��156��6�   6�   �� 5%   
   -   5        $ price��5%      $��5��68   $��1��6E   $��2��6U   $��217,22,0.333,22.333q�6i   ��6!   �� *price+6i   �� 5&   
   -   5        $��BtnBuyThing��5&   '   $��Вывести чек��6   $��5��6U   $��20(�6b   $��3��6p   $��35��6�   $	��145��6�   5'      5(      