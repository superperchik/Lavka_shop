   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.UserForm   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  
ThingsForm��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �� -   5        $��
ThingsUser��5       $��1��6   $��Disabled=�62   $��Center=�6h   ��5      �� 5      .R�5      �  � Orientation$ 
Horizontal=�6    $��Center=�6:   6Y   5      ��5      �� 5      .R�5      � $��30q�6   $	��500��6'    5      �� 5      $��70 �6,   6:   �� 5      $	��310 �6,   6;   �� 5      $
��auto �6,   6<   �� 5      $
��auto �6,   6<   .+�5       �� $	��400��6    $��1��6,   $
��Fill=�69   $��Center=�6H   $��5q�6e   ��5!      �� 5"   "    �� Path$ image�6*    �� TargetNullValue 5#   &   ��5$   *   Resources/foto.jpg��6L   5&   #   5(      �� 5)      $��Center=�6:    �� TextAlignment$ Center=�6U   $	��390��6l   $
��Wrap=�6x   $��Center=�6�   $	��5 5q�6�   $��26(�6�   $��0��6�   ��6$   �� *name+6�   �� 5*      $��2��6V   $��5 5 5 15q�6c   $��Center=�6u   $��26(�6�   $
��Bold"�6�   ��6$   �� *price+ �� StringFormat$ 
{0:N2} RUB��6�   �� 5+      $��3��6A   $��14(�6N   $
��Left=�6]   ��6$   �� *description+6z   �� 5,      $��2��6[   $��16(�6h   $��Right=�6v   ��6$   �� *count+$ Количество: {0}��6�   �� 5-      $��2��6^   $��16(�6k   $
��Left=�6y   ��6$   �� *	condition+$ Состояние: {0}��6�   �� 5.      $��BtnBuy��6!   -   5        $��Купить��5.   /   $	��100��6@   $��15(�6L   $��Center=�6Z   $	��Top=�6w   6�   5/      50      52      53      54      