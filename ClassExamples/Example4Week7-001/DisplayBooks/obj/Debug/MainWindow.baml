   M S B A M L   `   `   `  ����G  CDisplayBooks, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DisplayBooksDisplayBooks  5   	   X TExample4Week7-001.BookLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulltRclr-namespace:Example4Week7_001.BookLibrary;assembly=Example4Week7-001.BookLibraryExample4Week7_001.BookLibrary 5   	       DisplayBooks.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DisplayBooks     5   	   jBookLibraryRclr-namespace:Example4Week7_001.BookLibrary;assembly=Example4Week7-001.BookLibrary     5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��5
   	   $	��800��5   	    � 	Resources 5         titleViewSource��%   &	        �� 5   
   6   5      .��5      � $��	0,0,0,0.5q�6    � DataContext# [  5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��50* �6   �� 5      $	��90* �6   .+�5   
   �� $��Query��6   $
��Left=�5       $��10q�5!      $	��Top=�5"      $	��274��5#      $��61��5$      $��20(�5%      �� 5&   
   -   5         ��Name$ 	titleCbox��5&      $��1��5'      $��10q�5(      5,      &   System.Windows.Controls.DataGrid  5/   
   -   5          Name$ titleDataGrid��5/         AutoGenerateColumns .     EnableRowVirtualization . $��10q�53      $��1��54      $��5��55      	   RowDetailsVisibilityMode$	 VisibleWhenSelected=�56      $��2��57      ��52      �� 
   Columns
 58      0  *System.Windows.Controls.DataGridTextColumn  59      -   5        title1Column��,  &System.Windows.Controls.DataGridColumn   Header$ Title 1��5;   %      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 5<   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5:   %   �� *Title1+5<   %     5=      -   5        copyrightColumn��$ 	Copyright��5?   %   $
 auto 5@   %    5>   %   �� *	Copyright+5@   %     5A      -   5        editionNumberColumn��$ Edition Number��5C   %   $
 auto 5D   %    5B   %   �� *EditionNumber+5D   %     5E      -   5        
iSBNColumn��$
 ISBN��5G   %   $
 auto 5H   %    5F   %   �� *ISBN+5H   %   5J      5M      5N      