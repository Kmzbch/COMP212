   M S B A M L   `   `   `  ����P  LWeek4_DataBindingsec1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Week4_DataBindingsec1Week4_DataBindingsec1  5   	   &     Week4_DataBindingsec1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Week4_DataBindingsec1     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��5	   	   $	��500��5
   	    � 	Resources 5         friendViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6    � ColumnDefinitions 5   
   �� 5      $	��13* �6   �� 5      $	��20* �6   .+�5   
   �� -   5         ��Name$ friendListView��5      $��32,10,31,135.5q�5       �� SelectionMode$ Single=�5      ��5      �� ��5      �� 5      .�5      ��  �� Property � �� �� Value$ Stretch=�5      �� 5       � ��$ Stretch=�5      5       �� View 5!      �� 5"      .P�5#      �� -   5        firstNameColumn��$��
First Name��5$   %   	 �� Width$	 80��5%   %   
 �� CellTemplate
 5&      �� 5'      .R�5(   "   �� $��
6,-1,-6,-1q�6*   ��5)   *   �� *	FirstName+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5*      5,      5-      5/      � 50   
   -   5         �Name$ grid1��50      $��1��51      $
��Left=�52      $��	68,43,0,0q�53      $	��Top=�54       55      �� 56      $
��Auto �6#   �� 57      $
��Auto �6#    � RowDefinitions 59      �� 5:      $
��Auto �6    �� 5;      $
��Auto �6    �� 5<      $
��Auto �6    .+�5>      �� $��First Name:��6   $��0��5?      $
��Left=�5@      $��3q�5A      $��0��5B      $��Center=�5C      �� 5D      -   5         ��Name$ firstNameTextBox��5D      $��1��5E      $
��Left=�5F      $��23��5G      $��3q�5H      $��0��5I      $��Center=�5K      $	��120��5L      ��5J      �� *	FirstName+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5L      �� 5M      $��
Last Name:��6   $��0��5N      $
��Left=�5O      $��3q�5P      $��1��5Q      $��Center=�5R      �� 5S      -   5        $ lastNameTextBox��5S      $��1��5T      $
��Left=�5U      $��23��5V      $��3q�5W      $��1��5X      $��Center=�5Z      $	��120��5[      ��5Y      �� *
LastName+$ TwoWay=�$ PropertyChanged=�5[      �� 5\      $��Email:��6   $��0��5]      $
��Left=�5^      $��3q�5_      $��2��5`      $��Center=�5a      �� 5b      -   5        $ emailTextBox��5b      $��1��5c      $
��Left=�5d      $��23��5e      $��3q�5f      $��2��5g      $��Center=�5i      $	��120��5j      ��5h      �� *Email+$ TwoWay=�$ PropertyChanged=�5j      5l      5n      5o      