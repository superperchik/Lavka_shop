   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.AddEditThings   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  AddEditThings��5	      .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��184* �6   �� 5      $
��217* �6   �� 5      $
��208* �6   �� 5      $
��191* �6   .+�5   
   �� $��2��6   $1��+Редактирование товаров��6(   $��30(�6F   $��Center=�6T   $��1��6q   $��37,0,42.333,0.333q�6�   $	��346��6�   6�   �� 5   
   $��Название��6   $��20(�6$   $��1��62   $��1��6?   $��Center=�6O   $��Center=�6l   $��26��6�   $	��165��6�   6�   �� 5   
   $��1��6(   $��1��65   $��2��6E   $��217,22.667,0.333,22.667q�6Y   ��6   �� *name+6Y   �� 5   
   $��Описание��6   $��20(�6$   $��2��62   $��1��6?   $��Center=�6O   $��Center=�6l   $��27��6�   $��67,24.333,67.333,23.333q�6�   $��83��6�   6�   �� 5   
   $��2��6/   $��1��6<   $��2��6L   $��217,22.333,0.333,23.333q�6`   ��6   �� *description+6`   �� 5    
   $��Количество��6    �� TextAlignment$ Center=�6&   $��20(�6=   $��3��6K   $��1��6X   $��Center=�6h   $��Center=�6�   $��27��6�   $	��156��6�   6�   �� 5!   
   $��3��6)   $��1��66   $��2��6F   $��217,21.667,0.333,23q�6Z   ��6   �� *count+6Z   �� 5"   
   $��Состояние��6   $ Center=�6%   $��20(�6<   $��4��6J   $��1��6W   $��Center=�6g   $��Center=�6�   $��26��6�   $	��156��6�   6�   �� 5#   
   $��4��6-   $��1��6:   $��2��6J   $��217,22,0.333,22.333q�6^   ��6   �� *	condition+6^   �� 5$   
   $��Стоимость��6   $ Center=�6%   $��20(�6<   $��5��6J   $��1��6W   $��Center=�6g   $��Center=�6�   $��26��6�   $	��156��6�   6�   �� 5%   
   $��5��6)   $��1��66   $��2��6F   $��217,22,0.333,22.333q�6Z   ��6   �� *price+6Z   �� 5&   
   -   5        $��BtnSaveThing��5&   %   $��Сохранить��6   $��5��6U   $��20(�6b   $��3��6p   $��35��6�   $	��145��6�   5'      5(      