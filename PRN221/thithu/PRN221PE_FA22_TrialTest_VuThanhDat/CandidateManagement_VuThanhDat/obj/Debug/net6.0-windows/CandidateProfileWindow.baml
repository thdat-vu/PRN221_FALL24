   M S B A M L   `   `   `  ����Y  UCandidateManagement_VuThanhDat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CandidateManagement_VuThanhDatCandidateManagement_VuThanhDat  5   	   ;    5CandidateManagement_VuThanhDat.CandidateProfileWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:CandidateManagement_VuThanhDat     5   	   -   5          � Title$  CandidateProfileWindow��5   	   $	��800��6(   $	��800��65   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��3* �6   �� 5      $
��197* �6   .+�5   
   �� $"��CANDIDATE PROFILE MANAGEMENT��6   $
��Left=�67   $��41��6R   $��
211,41,0,0q�6^   $	��Top=�6r   $	��428��6�   $��24(�6�   $
��Bold"�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��1��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.032Q�6&   T� 5      5      5      �� 5   
   -   5         ��Name$ txtCandidateID��5      $
��Left=�6*   $��130,145,0,0q�6E    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   $	��120��6�   $��1��6�   �� 5   
   -   5         ��Name$ lblCandidateID��5      $��Candidate ID��6(   $
��Left=�6?   $��
41,137,0,0q�6Z   $	��Top=�6n   $��1��6�   �� 5   
   -   5        $ txtFullName��5      $
��Left=�6'   $��130,176,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��120��6�   $��1��6�   �� 5   
   -   5        $ lblFullName��5      $��	Full Name��6%   $
��Left=�69   $��
41,168,0,0q�6T   $	��Top=�6h   $��1��6�   �� 5   
   -   5        $ txtImageURL��5      $
��Left=�6'   $��130,225,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��120��6�   $��1��6�   �� 5   
   -   5        $ lblImageURL��5      $��	Image URL��6%   $
��Left=�69   $��
41,217,0,0q�6T   $	��Top=�6h   $��1��6�   �� 5   
   $��Label��6   $
��Left=�6    $��
41,266,0,0q�6;   $	��Top=�6O   $��1��6g   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpBirthDate��5      $
��Left=�6*   $��31��6E   $��130,261,0,0q�6Q   $	��Top=�6f   $	��120��6~   $��1��6�   �� 5    
   -	   5         ��Name$ cboJobPosting��5       $
��Left=�6*   $��454,150,0,0q�6E   $	��Top=�6Z   $	��180��6r   $��1��6~   �� 5!   
   -
   5        $ lblJobPosting��5!      $��Job Posting��6'   $
��Left=�6=   $��378,143,0,0q�6X   $	��Top=�6m   $��1��6�   �� 5"   
   -   5        $ txtDescription��5"      $
��Left=�6*   $��388,243,0,0q�6E   $
 Wrap=�6Z   $��TextBox��6n   $	��Top=�6}   $	��246��6�   $��49��6�   $��1��6�   �� 5#   
   $��Label��6   $
��Left=�6    $��	388,0,0,0q�6;   $��Center=�6N   $��1��6i   &   System.Windows.Controls.DataGrid  5$   
   -   5        	  Name$	 dataCandidateProfile��5$      $
��Left=�61   $	��122��6L   $��
79,302,0,0q�6Y   $	��Top=�6m   $	��555��6�   $��1��6�   �� 5%   
   -   5        
 ��Name$
 btnAdd��5%      $	��Add��6!   $
��Left=�6/   $��
79,480,0,0q�6J   $	��Top=�6^   $��51��6v   $	��102��6�   ���	#FF1FDD1D$��1��6�   6�   �� 5&   
   -   5        $
 	btnUpdate��5&      $��Update��6$   $
��Left=�65   $��218,480,0,0q�6P   $	��Top=�6e   $��51��6}   $	��102��6�   ���	#FFCCD610$��1��6�   �� 5'   
   -   5        $
 	btnDelete��5'      $��Delete��6$   $
��Left=�65   $��356,480,0,0q�6P   $	��Top=�6e   $��51��6}   $	��102��6�   ���	#FFEE3D0C$��1��6�   6�   �� 5(   
   -   5        $
 btnClose��5(      $��Close��6#   $
��Left=�63   $��493,480,0,0q�6N   $	��Top=�6c   $��51��6{   $	��102��6�   ���	#FF07E0E8$��1��6�   �� 5)   
   -   5        $ lblDescription��5)      $��Description��6(   $
��Left=�6>   $��388,212,0,0q�6Y   $	��Top=�6n   $ 0.5,0.5&�6�   $��1��6�   z�5*      V� 5+      .~�5,      �� �� 5-      �� 5.      $ -0.729Q�6&   T� 5/      50      52      54      55      