   M S B A M L   `   `   `  ����?  ;Mupl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MuplMupl  5   	       Mupl.AdminPanel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Mupl     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$
  MUPL��5	   	   $	��750��6   $
��1000��6#   .��5
      � ���#161A1D.+�5   
    � -   5        $��	MainFrame��5        � NavigationUIVisibility$ Visible=�6!   � 5   
   $
��Left=�6   $	��200��6*   $	��250��69   ���	#FF0A0B0C.+�5      �� .+�5      �� $��Century Gothic)�6   $��22(�67   ���#fff.@�5      �� $��50��6#   $��0 10 0 0q�6/   .��5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      	� -   5         	�Name$ 
UsersTable��5   C    d� 	IsChecked$
 TrueY�6W    	� 	GroupName$ table��6h   $��15 0 0 0q�6z   $��Users��6�   $��Center=�6�   $	��182��6�   $��40��6�   5      5      �� 5      $��40��6#   .��5      �� $ 
Horizontal=�6%   .+�5      	� -   5        $ PerformerTable��5   G   $ table��6_   $��15 0 0 0q�6q   $��	Performer��6�   $��Center=�6�   $	��182��6�   $��40��6�   5      5      �� 5      $��40��6#   .��5      �� $ 
Horizontal=�6%   .+�5      	� -   5        $ 
AlbumTable��5   C   $ table��6W   $��15 0 0 0q�6i   $��Album��6{   $��Center=�6�   $	��182��6�   $��40��6�   5      5      �� 5      $��40��6#   .��5      �� $ 
Horizontal=�6%   .+�5       	� -   5        $ 
TrackTable��5    C   $ table��6W   $��15 0 0 0q�6i   $��Track��6{   $��Center=�6�   $	��182��6�   $��40��6�   5!      5"      �� 5#      $��40��6#   .��5$      �� $ 
Horizontal=�6%   .+�5%      	� -   5        $ 
LabelTable��5%   C   $ table��6W   $��15 0 0 0q�6i   $��Label��6{   $��Center=�6�   $	��182��6�   $��40��6�   5&      5'      �� 5(      $��40��6#   .��5)      �� $ 
Horizontal=�6%   .+�5*      	� -   5        $ 
GenreTable��5*   C   $ table��6W   $��15 0 0 0q�6i   $��Genre��6{   $��Center=�6�   $	��182��6�   $��40��6�   5+      5,      5-      5.      5/      � 51   
   -   5        $��	GridGenre��51      $y�Hidden=�6    ���	#FF673AB7$��Stretch=�6K   $��	205,0,0,0q�6i   .+�52      &   System.Windows.Controls.DataGrid  -	   5          Name$ 	dataGenre��52         AutoGenerateColumns .     
IsReadOnly . $
��Left=�6X   $	��607��6s   $��	10,10,0,0q�6�   $	��Top=�6�   $
��auto��6�   	   Columns	 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *id+6L     55      $

 Name��6)   $ * 6P    67   �� *name+6P   4  .System.Windows.Controls.DataGridTemplateColumn  56      $ * 6-      CellTemplate 57      �� 58      .R�59   "   �� $��BtnEditGenre��68   -
   5        $
��Edit��59   )   6L   5:      5<      5>      5?      � 5A   
   -   5        $��	GridLabel��5A      $y�Hidden=�6    ���	#FF673AB7$��Stretch=�6K   $��	205,0,0,0q�6i   .+�5B        -   5        $ 	dataLabel��5B       .   . $
��Left=�6X   $	��607��6s   $��	10,10,0,0q�6�   $	��Top=�6�   $
��auto��6�   	 5C        5D      $
 ID��6)   $ * 6L    65   �� *id+6L     5E      $

 Name��6)   $ * 6P    67   �� *name+6P     5F      $
 Description��6)   $ * 6^    6>   �� *description+6^     5G      $
 Photo��6-   $ * 6<    5H      �� 5I      .R�5J   "   �� $
��Left=�6(   $��64��6C   $
��auto��6N   ��6\   �� *	picture+5K      5M        5N      $ * 6-    5O      �� 5P      .R�5Q   "   �� $��BtnLabelEdit��68   -   5        $
��Edit��5Q   )   6L   5R      5T      5V      5W      � 5Y   
   -   5        $��	GridUsers��5Y      $y�Visible=�6    ���	#FF673AB7$��Stretch=�6L   $��	205,0,0,0q�6j   .+�5Z        -   5        $ 	dataUsers��5Z       .   . $
��Left=�6X   $	��607��6s   $��	10,10,0,0q�6�   $	��Top=�6�   $
��auto��6�   	 5[        5\      $
 ID��6)   $ * 6L    65   �� *id+6L     5]      $
 Login��6)   $ * 6R    68   �� *login+6R     5^      $
 Password��6)   $ * 6X    6;   �� *
password+6X     5_      $

 Role��6)   $ * 6P    67   �� *role+6P     5`      $
 Email��6)   $ * 6R    68   �� *email+6R     5a      $
 Photo��6-   $ * 6<    5b      �� 5c      .R�5d   "   �� $
��Left=�6(   $��64��6C   $
��auto��6N   ��6\   �� *	picture+5e      5g        5h      $ * 6-    5i      �� 5j      .R�5k   "   �� $��BtnUsersEdit��68   -   5        $
��Edit��5k   )   6L   5l      5n      5p      5q      � 5s   
   -   5        $��GridPerformer��5s      $y�Hidden=�6$   ���	#FF673AB7$��Stretch=�6O   $��	205,0,0,0q�6m   .+�5t        -   5        $ dataPerformer��5t       .   . $
��Left=�6\   $	��607��6w   $��	10,10,0,0q�6�   $	��Top=�6�   $
��auto��6�   	 5u        5v      $
 ID��6)   $ * 6L    65   �� *id+6L     5w      $
 Label��6)   $ * 6V    68   �� *	labelName+6V     5x      $

 Name��6)   $ * 6P    67   �� *name+6P     5y      $
 Description��6)   $ * 6^    6>   �� *description+6^     5z      $
 Photo��6-   $ * 6<    5{      �� 5|      .R�5}   "   �� $
��Left=�6(   $��64��6C   $
��auto��6N   ��6\   �� *	picture+5~      5�        5�      $ * 6-    5�      �� 5�      .R�5�   "   �� $��BtnPerformerEdit��68   -   5        $
��Edit��5�   )   6P   5�      5�      5�      5�      � 5�   
   -   5        $��	GridAlbum��5�      $y�Hidden=�6    ���	#FF673AB7$��Stretch=�6K   $��	205,0,0,0q�6i   .+�5�        -   5        $ 	dataAlbum��5�       .   . $
��Left=�6X   $	��607��6s   $��	10,10,0,0q�6�   $	��Top=�6�   $
��auto��6�   	 5�        5�      $
 ID��6)   $ * 6L    65   �� *id+6L     5�      $

 Name��6)   $ * 6P    67   �� *name+6P     5�      $
 
Album type��6)   $ * 6\    6=   �� *
album_type+6\     5�      $
 Photo��6-   $ * 6<    5�      �� 5�      .R�5�   "   �� $
��Left=�6(   $��64��6C   $
��auto��6N   ��6\   �� *	picture+5�      5�        5�      $ * 6-    5�      �� 5�      .R�5�   "   �� $��BtnAlbumEdit��68   -   5        $
��Edit��5�   )   6L   5�      5�      5�      5�      � 5�   
   -   5        $��	GridTrack��5�      $y�Hidden=�6    ���	#FF673AB7$��Stretch=�6K   $��	205,0,0,0q�6i   .+�5�        -   5        $ 	dataTrack��5�       .   . $
��Left=�6X   $	��607��6s   $��	10,10,0,0q�6�   $	��Top=�6�   $
��auto��6�   	 5�        5�      $
 ID��6)   $ * 6L    65   �� *id+6L     5�      $
 	Performer��6)   $ * 6^    6<   �� *performerName+6^     5�      $
 Album��6)   $ * 6V    68   �� *	almumName+6V     5�      $

 Name��6)   $ * 6P    67   �� *name+6P     5�      $

 Path��6)   $ * 6P    67   �� *path+6P     5�      $

 Date��6)   $ * 6P    67   �� *date+6P     5�      $ * 6-    5�      �� 5�      .R�5�   "   �� $��BtnTrackEdit��68   -   5        $
��Edit��5�   )   6L   5�      5�      5�      5�      � 5�   
   $��Bottom=�6   $��80��6*   ���	#FF101315.+�5�      �� -   5        $��BtnAdd��5�   >   $	��Add��6   $
��Left=�6#   $��215,24,0,24q�6a   $
��auto��6v   �� 5�      -   5        $��	BtnDelete��5�   B   $��Delete��6   $��Right=�6&   $��
0,24,10,24q�6k   $
��auto��6   5�      5�      5�      