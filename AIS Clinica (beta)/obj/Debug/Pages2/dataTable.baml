   M S B A M L   `   `   `  ����P  LWPFModernVerticalMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:WPFModernVerticalMenu.Pages2WPFModernVerticalMenu.Pages2  5      ,    &WPFModernVerticalMenu.Pages2.dataTable   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      8local*clr-namespace:WPFModernVerticalMenu.Pages2   5        N� Title$  	dataTable��5
      .��5      � -   5           SecundaryBackgroundColor#���   5       � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      .+�5   
   � $��0��6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      �� 5      $��40 �6   .+�5   
   �� -   5         ��Name$ values��5      $��Записей: ��5      $��0��5      $��0��5       
�������$��15(�5"      $��Center=�5#      $��Medium"�5$      $��
Montserrat)�5%      $��10 0 0 0q�5&      �� 5(   
   $��Найти: ��6   $��0��5)      $��2��5*      
�������$��15(�5,      $��Center=�5-      $��Medium"�5.      $��
Montserrat)�5/      $��Right=�50      $��	0 5 210 0q�51      �� 53   
   -   5         ��Name$ txtEmail��53      $��0��54      $��2��55      $��13(�56      
������ $��Medium"�58      $��
Montserrat)�59      
������� �� 
CaretBrush
 �����
�������$��0 0 0 1q�5=      $��25��5>      $��Right=�5?      $��Center=�5@      $��0 2 5 0q�5A      $	��198��6+   .��67   5B      .  (MahApps.Metro.IconPacks.PackIconMaterial  5D   
      Kind$ Magnify=�6    $��15��6/   $��15��6:   $��0��6F   $��3��6S   $��Center=�5E       $��0 0 15 0q�6;   
�������6M   5F      &   System.Windows.Controls.DataGrid  5H   
   -   5          Name$ 	usersGrid��5H   1   $��1��6   $��0 5 0 0q�6      DataGridRowStyle1   RowStyle# �  6D     DataGridColumnHeaderStyle1	   ColumnHeaderStyle#	 �  6s     DataGridCellStyle1
   	CellStyle#
 �  6�     DataGridStyle1#���  6�      Columns 5I      0  *System.Windows.Controls.DataGridTextColumn  5J      ,  &System.Windows.Controls.DataGridColumn   Header$ #��6%      
IsReadOnly .    CanUserResize .     Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6e   �� *	idUsers+  5K      $% Имя пользователя��6%    .  .  $
 Auto 6g    6t   �� *login+  5N      $ Пароль��6%    . $ * 6G    6Q   �� *
password+  5O      $ Должность��6%    . $ * 6J    6T   �� *role+  5P      $/ )Последняя авторизация��6%    . $ * 6V    6`   �� *
lastSeen+  5Q      $ Личное дело��6%    . $ * 6L    6V   �� *workerInfoID+4  .System.Windows.Controls.DataGridTemplateColumn  5S      $ Операции��6)    . $ * 6M      CellTemplate 5T      �� 5U      .R�5V      ��  �� Orientation$ 
Horizontal=�6)   .+�5W   "   ��   editGridButton#��[ 6)   .��5X   &     $ PencilOutline=�6<     gridButtonIcon#��[ 6Q   5Y   #   �� 5Z   "   -   5          removeGridButton#��[ 5Z   )   $��5 0 0 0q�6S   .��5[   &     $ DeleteOutline=�6<   #��[ 6Q   5\   #   5]      5^      5`      5c      5g      5i      