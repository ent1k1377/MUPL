   M S B A M L   `   `   `  ����?  ;Mupl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MuplMupl  5   	       	Mupl.Main   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Mupl     5   	     � Title$
  MUPL��5   	   $	��750��6   $
��1000��6#   .��5	      � ���#161A1D.+�5
   
   � $
��Left=�6   $	��200��6*   $	��250��69   ���	#FF0A0B0C.+�5      �� .+�5      �� $��Century Gothic)�6   $��18(�67   ���#fff.@�5      �� $��50��6#   $��0 10 0 0q�6/   .��5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $��Images/more_52px.png��6$   $��28��6B   $��Center=�6N   $��14 0 0 0q�6i   �� 5      $��15 0 0 0q�6(   $��Settings��6:   $��Center=�6J   5      5      �� 5      $��40��6#   .��5      �� $ 
Horizontal=�6%   .+�5      �� $��Images/home_64px.png��6$   $��28��6B   $��Center=�6N   $��14 0 0 0q�6j   �� 5      $��15 0 0 0q�6(   $
��Home��6:   $��Center=�6F   5      5      �� 5      $��40��6#   .��5      �� $ 
Horizontal=�6%   .+�5      �� $��Images/search_100px.png��6$   $��28��6E   $��Center=�6Q   $��14 0 0 0q�6m   �� 5      $��15 0 0 0q�6(   $��Search��6:   $��Center=�6H   5      5      �� 5      $��40��6#   .��5       �� $ 
Horizontal=�6%   .+�5!      �� $��Images/folder_52px.png��6$   $��28��6D   $��Center=�6P   $��14 0 0 0q�6l   �� 5"      $��15 0 0 0q�6(   $��Your Library��6:   $��Center=�6N   5#      5$      5%      5&      5'      r� 5(   
   -   5        $��Audio��5(   +   $y�Hidden=�6    r� LoadedBehavior$ Manual=�68    r� UnloadedBehavior$ Pause=�6P   � 5)   
   -   5        $��	GridTrack��5)      $y�Visible=�6    ���	#FF673AB7$��Stretch=�6L   $��	205,0,0,0q�6j   .+�5*      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataTrack��5*         AutoGenerateColumns .     
IsReadOnly . $
��Left=�6X   $	��607��6s   $��	10,10,0,0q�6�   $	��Top=�6�   $
��auto��6�      Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Performer��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6^   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6<   �� *performerName+6^     5.      $ Album��6)   $	 * 6V   
 68   �� *	almumName+6V     5/      $
 Name��6)   $	 * 6P   
 67   �� *name+6P     50      $
 Date��6)   $	 * 6P   
 67   �� *date+6P   4  .System.Windows.Controls.DataGridTemplateColumn  51      $	 * 6-      CellTemplate 52      �� 53      .R�54   "   �� $��BtnPlayAudio��68   -   5        $
��Play��54   )   6L   55      57        58      $	 * 6-    59      �� 5:      .R�5;   "   �� $��BtnPauseAudio��69   -   5        $��Pause��5;   )   6N   5<      5>      5@      5A      � 5C   
   $��Bottom=�6   $��80��6*   ���	#FF1013155E      5G      5H      