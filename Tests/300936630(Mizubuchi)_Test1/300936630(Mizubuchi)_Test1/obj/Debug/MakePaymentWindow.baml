   M S B A M L   `   `   `  ����U  Q300936630(Mizubuchi)_Test1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:_300936630_Mizubuchi__Test1_300936630_Mizubuchi__Test1  5   	   3    -_300936630_Mizubuchi__Test1.MakePaymentWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:_300936630_Mizubuchi__Test1     5   	     � Title$  MakePaymentWindow��5   	   $	��450��5	   	   $	��800��5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��65* �6   �� 5      $
��121* �6   �� 5      $	��71* �6   �� 5      $	��96* �6   �� 5      $	��70* �6    � ColumnDefinitions 5   
   �� 5      $
��287* �6   �� 5      $
��508* �6   .+�5   
   �� $��	Access ID��6   $��20(�5      $��center=�5      $��37��5      $
��0,14q�5      �� 5   
   -   5         ��Name$ lblLogInUserId��5      $��Label��5      $��1��5      $��20(�5       $��center=�5!      $��37��5"      $
��0,14q�5#      �� 5$   
   $��Account��6   $��2��5%      $��20(�5&      $��center=�5'      $��38��5(      $��10,22.5,498,10.5q�5)      $��2��5*      �� 5+   
   $��Amount��6   $��3��5,      $��20(�5-      $��center=�5.      $��38��5/      $��	0,28,0,30q�50      �� 51   
   -   5         ��Name$ 	tbxAmount��51      $��1��52      $��3��53      $��20(�54       �� TextWrapping$
 Wrap=�55      $��0��56      $��0,9.5,249,10.5q�57      �� 58   
   -   5        $��Make Payment��58      $��1��59      $��4��5:      $��20(�5;      $��259,3.5,0,0.5q�5<      5=      �� 5>   
   -   5         ��Name$ accountCbox��5>      $��1��6(   $
��Left=�5?      $��
139,38,0,0q�5@      $��2��5A      $	��Top=�5B      $	��120��5C      $��22��5D      &   System.Windows.Controls.DataGrid  5E   
   -   5          Name$ dgAccountList��5E      $��1��6*   $
��Left=�5F      $	��100��5G      $��
107,37,0,0q�5H      $��1��5I      $��2��5J      $	��Top=�5K      $	��100��5L      ��5M      �� 5N      5Q      5R      