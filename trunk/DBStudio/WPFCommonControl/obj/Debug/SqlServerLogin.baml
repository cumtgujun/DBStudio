   M S B A M L   `   `   `  ����K  GWPFCommonControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPFCommonControlWPFCommonControl  5      ,    &WPFCommonControl.SqlServerLoginControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      /Selfclr-namespace:WPFCommonControl     5        J� CommandBindings  5      )  #System.Windows.Input.CommandBinding  5      -   5           Command$* $Self:ControlCommands.GetTableListCmd��5      6s   .��5      � $��5q�6   .+�5	   
   �� .+�5
      �� -   5         ��Name$ paneServername��5
   @    �� Orientation$ 
Horizontal=�6   $
��0 2 q�62   .+�5      �� $	��120��6   $��Right=�6%   .��6H   Server ip(name)6Y   �� 5      -   5         ��Name$ cmbServername��5      $	��200��63    �� 
IsEditable .  �� 
IsReadOnly .  6Q   5      �� 5      -   5        $ panelUsername��5   @   $ 
Horizontal=�6   $
��0 2 q�62   .+�5      �� $��Right=�6   $	��120��6<   .��6I   
username6S   �� 5      -   5        $��txtUsername��5      $	��200��6.   5      �� 5      -   5        $ panelPassword��5   @   $ 
Horizontal=�6   $
��0 2 q�62   .+�5      �� $	��120��6   $��Right=�6%   .��6H   
password6R   G� 5      -   5         G�Name$ passwordBox1��5      $	��200��64   6@   5      �� 5      -   5        $ panelDatabase��5   @   $ 
Horizontal=�6   $
��0 2 q�62   .+�5      �� $��Right=�6   $	��120��6;   .��6G   database name6V   �� 5      -	   5        $ 	cmbDbName��5   '   $	��200��6   6'   �� 5      -
   5         ��Name$ butEmulatorDbList��5      $*��$Self:ControlCommands.GetTableListCmd��5      $��26��5      ��5      F� 5      -   5        	 F�Name$
	 Star��5    E   $��1.500000��5      ���	#ffffffff
 �� StrokeMiterLimit$
 1.000000Q�6M   
����  �j����Vɕ �� �bv� �7h ����t ��`� �Ա �V%� ]��Vɕ �?� �nkH ]���/W �Ա �@� ��t �bo �7h �Vɕ �� $
��Left=�5       $��Center=�6*   6E    � ToolTip 5"      �� 5#      .+�5$      �� $T��NRecommend you click this button to emulator the table list of current database��6(   5%      5'      5(      �� 5)      -   5        $ panelDatabaseFile��5)   @   $ 
Horizontal=�6   $
��0 2 q�62   $y�	Collapsed=�6[   .+�5*      �� $��Right=�6   $	��120��6<   $��Database File��6H   �� 5+      -   5         ��Name$ txtDbFileLocation��5+      $	��200��65   �� 5,      -   5        $ butSelectFile��5,      $�� ... ��60   6@   5-      �� 5.      $ 
Horizontal=�6   $
��0 2 q�62   .+�5/      �� $��Right=�6   $	��120��6<   .��6H   Connect Type6V   �� 50      -   5        $ cmbConnMode��50      $	��200��61   6=   51      �� 52      $ 
Horizontal=�6   $
��0 2 q�62   .+�53      �� $��Right=�6   $	��120��6;   .��6H   Port6N   �� 54      -   5        $ txtPort��54   &   $	��200��6   .��67   14336=   55      �� 56      -   5         ��Name$ chkIsTrustedConn��56   *    d� 	IsChecked$ FalseY�6   $
��0 2 q�57      $��Center=�6&   .��6C   Is Trusted Connection6Z   59      5=      5>      