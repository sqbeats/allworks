   M S B A M L   `   `   `  ����P  LWPFModernVerticalMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:WPFModernVerticalMenu.Pages2WPFModernVerticalMenu.Pages2  5      /    )WPFModernVerticalMenu.Pages2.personalFile   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5      <d2http://schemas.microsoft.com/expression/blend/2008   5      8local*clr-namespace:WPFModernVerticalMenu.Pages2   5        N� Title$  personalFile��5
       � 	Resources 5       	  templ��%l   &	        �� 5   
   .R�5      �� $
��Wrap=�61   
���   ���6   �� *	address+6E   5      5      .��5      � -   5          SecundaryBackgroundColor#���  5       � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   �� 5      �� 5       $��40 �6#   .+�5#      �� -   5         ��Name$ values��5$      $��Записей: ��5#      $��0��5%      $��0��5&      
�������$��15(�5(      $��Center=�5)      $��Medium"�5*      $��
Montserrat)�5+      $��10 0 0 0q�5,      �� 5.      $��Найти: ��6   $��0��5/      $��2��50      
�������$��15(�52      $��Center=�53      $��Medium"�54      $��
Montserrat)�55      $��Right=�56      $��	0 5 210 0q�57      �� 59      -   5         ��Name$ txtEmail��59      $��0��5:      $��2��5;      $��13(�5<      
������ $��Medium"�5>      $��
Montserrat)�5?      
������� �� 
CaretBrush
 �����
�������$��0 0 0 1q�5C      $��25��5D      $��Right=�5E      $��Center=�5F      $��0 2 5 0q�5G      $	��198��6+   .��67   5H      .  (MahApps.Metro.IconPacks.PackIconMaterial  5J         Kind$ Magnify=�6$   $��15��63   $��15��6>   $��0��6J   $��3��6W   $��Center=�5K       $��0 0 15 0q�6;   
�������6M   5L      &   System.Windows.Controls.DataGrid  5P   
   -   5          Name$ personalGrid��5P   1   $��1��6   $��0 5 0 0q�6      DataGridRowStyle1	   RowStyle#	 �  6G     DataGridColumnHeaderStyle1
   ColumnHeaderStyle#
 �  6v     DataGridCellStyle1   	CellStyle# �  6�     DataGridStyle1#���  6�      Columns 5U      0  *System.Windows.Controls.DataGridTextColumn  5V      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер дела��6%      
IsReadOnly .    CanUserResize .     Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6a   -   5        workerInfoID��1  +System.Windows.Controls.DataGridBoundColumn   Binding 5V   n   �� *workerInfoID+6�     5W      $ Фамилия��6%    .  .  $
 Auto 6^    6k   �� *	surname+  5[      $ Имя��6%    . $ * 6D    6N   �� *name+  5\      $ Отчество��6%    . $ * 6I    6S   �� *
secondname+  5]      $ 
Адрес��6%    . $ * 6F    6P   �� *	address+  5^      $ День рождения��6%    . $ * 6N    6X   �� *
birthday+ �� StringFormat$ {0:dd.MM.yy}��  5_      $! Номер телефона��6%    . $ * 6O    6Y   �� *phoneNumber+  5`      $ 
Почта��6%    . $ * 6F    6P   �� *email+4  .System.Windows.Controls.DataGridTemplateColumn  5b      $ Операции��6)    . $ * 6M      CellTemplate 5c      �� 5d      .R�5e      ��  �� Orientation$ 
Horizontal=�6)   .+�5f   "   ��   editGridButton#��[ 6)   .��5g   &     $ PencilOutline=�6<     gridButtonIcon#��[ 6Q   5h   #   �� 5i   "   -   5          removeGridButton#��[ 5i   )   $��5 0 0 0q�6S   .��5j   &     $ DeleteOutline=�6<   #��[ 6Q   5k   #   5l      5m      5o      5r      5v      5w      