   M S B A M L   `   `   `  ����%  !ContractStatementManagementSystem7    1ContractStatementManagementSystem.InsertWarehouse   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  增加记录��5   	   $	��250��6   $	��300��6#    � WindowStartupLocation$ CenterScreen=�6/   .��5      �� $��Center=�6   $��Center=�6.   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Right=�6.   $��Center=�6J   .+�5      �� $��5q�6   $��日志名：��6#   �� 5      -   5        $��
tb_LogName��5      $��5q�6(   $	��170��63   $��23��6?   5	      �� 5
   
   $ 
Horizontal=�6   $��Right=�6.   $��Center=�6J   .+�5      �� $��5q�6   $��发货数量：��6#   �� 5      -   5        $��tb_Shipments��5   $    �� 	MaxLength$ 5��6   $��5q�68   $	��170��6C   $��23��6O   6[   5      �� 5   
   $ 
Horizontal=�6   $��Right=�6.   $��Center=�6J   $��0,0,5,0q�6e   .+�5      �� -   5        $��tb_Insufficient_Warn��5      $��库存量不足��64   
���  ��$y�	Collapsed=�6R   6k   5      �� 5   
   $ 
Horizontal=�6   $��Right=�6.   $��Center=�6J   $��0,0,5,0q�6e   .+�5      �� -   5        $��tb_Shipments_Warn��5      $-��'发货数量不能大于未发货数量��61   
���  ��$y�	Collapsed=�6W   6p   5      �� 5   
   $ 
Horizontal=�6   $��Right=�6.   $��Center=�6J   .+�5      �� $��5q�6   $��发货日期：��6#   (  "System.Windows.Controls.DatePicker  5      -   5        $��tb_ShippedDate��5      $��5q�6/   $	��170��6:   5      �� 5   
   -   5        $��btn_Save��5      $��保存��6!   $��75��6.   $��0,20,0,0q�69   6d   5      5      