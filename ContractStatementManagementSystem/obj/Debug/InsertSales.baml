   M S B A M L   `   `   `  ����%  !ContractStatementManagementSystem3    -ContractStatementManagementSystem.InsertSales   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  增加记录��5   	   $	��240��6   $	��350��6#    � WindowStartupLocation$ CenterScreen=�6/   .��5      �� $��Center=�6   $��Center=�6.   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Right=�6.   $��Center=�6J   .+�5      �� $��5q�6   $��日志名：��6#   �� 5      -   5        $��
tb_LogName��5      $��5q�6(   $	��170��63   $��23��6?   5	      �� 5
   
   $ 
Horizontal=�6   $��Right=�6.   $��Center=�6J   .+�5      �� $��5q�6   $��服务款项：��6#   �� 5      -   5        $��
cb_Service��5      $��5q�6)   $	��170��64   $��23��6@    �� DisplayMemberPath$ Service��6L   5      �� 5   
   $ 
Horizontal=�6   $��Right=�6.   $��Center=�6J   .+�5      �� $��5q�6   $��收款金额：��6#   �� 5      -   5        $��	tb_Amount��5   %    �� 	MaxLength$ 15��6   $��5q�66   $	��170��6A   $��23��6M   6Y   5      �� 5   
   $ 
Horizontal=�6   $��Right=�6.   $��Center=�6J   $��0,0,5,0q�6e   .+�5      �� -   5        $��tb_Amount_Warn��5      $*��$收款金额不能大于未收金额��6.   
���  ��$y�	Collapsed=�6S   6l   5      �� 5   
   -   5        $��btn_Save��5      $��保存��6!   $��75��6.   $��0,20,0,0q�69   6d   5      5      