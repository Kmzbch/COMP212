   M S B A M L   `   `   `  ����T  PKei-Mizubuchi_Sec001-Ex02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Kei_Mizubuchi_Sec001_Ex02Kei_Mizubuchi_Sec001_Ex02  5   	   *    $Kei_Mizubuchi_Sec001_Ex02.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Kei_Mizubuchi_Sec001_Ex02     5   	     � Title$  
MainWindow��5   	   $	��450��5	   	   $	��800��5
   	   .��5      � .+�5   
   �� -   5         ��Name$ btnFindLargest��5      $��FIND LARGEST��5      $
��Left=�5      $��437,190,0,0q�5      $	��Top=�5      $	��154��5      $��21��5      �� 5   
   -   5         ��Name$ txtStartIndex��5      $
��Left=�5      $��23��5      $��
523,27,0,0q�5       �� TextWrapping$
 Wrap=�5      $��0��5      $	��Top=�5      $	��120��5      �� 5   
   $
��Left=�6   $
��Wrap=�5      $��	TextBlock��5      $	��Top=�5      �� 5    
   -   5        $ txtEndIndex��5       $
��Left=�5!      $��23��5"      $��
506,70,0,0q�5#      $
 Wrap=�5$      $��9��5%      $	��Top=�5&      $	��120��5'      �� 5(   
   $��
startIndex��6   $
��Left=�5)      $��
424,23,0,0q�5*      $	��Top=�5+      �� 5,   
   $��endIndex��6   $
��Left=�5-      $��
437,70,0,0q�5.      $	��Top=�5/      �� 51   
   $��
Array(int)��6   $��16(�52      $
��Left=�53      $��	32,41,0,0q�54      $	��Top=�55      �� 56   
   -   5        $ tbxIntArray��56      $��Generate array first��57       �� 
IsReadOnly . $
��Left=�59      $��80��5:      $��
136,13,0,0q�5;      $
 Wrap=�5<      $	��Top=�5=      $	��233��5>      �� 5?   
   $��Array(Double)��6   $��16(�5@      $
��Left=�5A      $	��Top=�5B      $��
10,174,0,0q�5C      �� 5D   
   -   5        $ tbxDoubleArray��5D      $��Generate array first��5E       . $
��Left=�5G      $	��136��5H      $
 Wrap=�5I      $	��Top=�5J      $	��232��5K      $��137,114,0,0q�5L      �� 5N   
   -   5        $ btnGenerateIntArray��5O      $��Generate Int Array��5N      $
��Left=�5P      $��398,114,0,0q�5Q      $	��Top=�5R      $	��126��5S       J� RenderTransformOrigin$ -1.24,-2.136&�5T      $��39��5V      �� 5W   
   -   5        $ btnGenerateDoubleArray��5X      $��Generate Double Array��5W      $
��Left=�5Y      $��563,114,0,0q�5Z      $	��Top=�5[      $	��126��5\      $ -1.24,-2.136&�5]      $��39��5_      5a      5b      