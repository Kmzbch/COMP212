   M S B A M L   `   `   `  ����T  P300936630(Mizubuchi)_ASS4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:_300936630_Mizubuchi__ASS4_300936630_Mizubuchi__ASS4  5   	   +    %_300936630_Mizubuchi__ASS4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:_300936630_Mizubuchi__ASS4     5   	     � Title$  
MainWindow��5	   	   $	��600��5
   	   $	��800��5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ btnGenerateArray��5      $��50q�5      $��Generate Array��5      $��1��5      5      �� 5   
   $��
Array(int)��6   $��16(�5      $
��Left=�5      $��	32,41,0,0q�5      $	��Top=�5      �� 5   
   -   5         ��Name$ tbxIntArray��5      $��Generate array first��5        �� 
IsReadOnly . $
��Left=�5"      $��80��5#      $��
136,13,0,0q�5$       �� TextWrapping$
 Wrap=�5%      $	��Top=�5&      $	��233��5'      �� 5(   
   $��Array(Double)��6   $��16(�5)      $
��Left=�5*      $	��Top=�5+      $��
10,174,0,0q�5,      �� 5-   
   -   5        $ tbxDoubleArray��5-      $��Generate array first��5.       . $
��Left=�50      $	��136��51      $
 Wrap=�52      $	��Top=�53      $	��232��54      $��137,128,0,0q�55      �� 56   
   -   5        $ 	btnSearch��56      $��Search��57      $��50q�58      $��1��59      $��1��5:      5;      �� 5<   
   $��	Search by��6   $��16(�5=      $
��Left=�5>      $	��Top=�5?      $��	29,74,0,0q�5@      $��1��5A       J� RenderTransformOrigin$ 0.485,1.564&�5B      �� 5C   
   -   5        $ tbxSearchBy��5C      $��Enter search key��5D      $
��Left=�5E      $��80��5F      $
 Wrap=�5G      $	��Top=�5H      $	��233��5I      $��
136,50,0,0q�5J      $��1��5K      	� 5L   
   -   5         	�Name$ rdbSearchInt��5L      	 d� 	IsChecked$
	 trueY�5M      
 	� 	GroupName$
 grpNumericType��5N      $��16(�5O      $��
search int��5P      $
��Left=�5Q      $��63,145.5,0,0q�5R      $��1��5S      $	��Top=�5T      	� 5U   
   -   5        $ rdbSearchDouble��5U      $
 grpNumericType��5V      $��16(�5W      $��search double��5X      $
��Left=�5Y      $��251,145.5,0,0q�5Z      $��1��5[      $	��Top=�5\      5^      5_      