   M S B A M L   `   `   `  ����Y  UCandidateManagement_VuThanhDat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CandidateManagement_VuThanhDatCandidateManagement_VuThanhDat  5   	   5    /CandidateManagement_VuThanhDat.JobPostingWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:CandidateManagement_VuThanhDat     5   	   -   5          � Title$  
JobPosting��5   	   $	��900��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��2* �6   �� 5      $	��33* �6   �� 5      $��6* �6   �� 5      $	��28* �6   �� 5      $	��71* �6   �� 5      $
��185* �6   �� 5      $	��32* �6   �� 5      $	��43* �6   .+�5   
   �� $��JOB POSTING SCREEN��6   $
��Left=�6-   $��
134,25,0,0q�6H   $	��Top=�6\   $
��Bold"�6t   $��26(�6�   $��4��6�   $��2��6�   �� 5   
   $��CandidateID��6   $
��Left=�6&   $��	52,86,0,0q�6A   $	��Top=�6T   $��3��6l   $��1��6�   �� 5   
   $��Title��6   $
��Left=�6    $��
52,132,0,0q�6;   $	��Top=�6O   $��3��6g   $��1��6{   �� 5   
   $��Description��6   $
��Left=�6&   $��
52,247,0,0q�6A   $	��Top=�6U   $��3��6m   $��1��6�   �� 5   
   $��PostDate��6   $
��Left=�6#   $��
52,191,0,0q�6>   $	��Top=�6R   $��3��6j   $��1��6~   �� 5   
   -   5         ��Name$ txtPostingID��5      $
��Left=�6(   $��	44,86,0,0q�6C    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��574��6�   $��18(�6�   $��4��6�   $��4��6�   �� 5   
   -   5        $ txtTitle��5      $
��Left=�6$   $��
44,132,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $	��574��6   $��18(�6�   $��4��6�   $��4��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dataPostDate��5      $
��Left=�6+   $��
44,204,0,0q�6F   $	��Top=�6Z   $	��574��6r   $��4��6~   $��4��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgJobPosting��5      $��53,424,42,331q�6U   $��7��6l    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��1��6�   z�5      V� 5      .~�5      �� �� 5        �� AngleX$ -0.894Q�6$   �� 5!      T� 5"       T� X$ -1.584Q�6)   5#      5%      �� 5&   
   -   5        	 ��Name$	 	btnCreate��5&      $��Create��6$   $
��Left=�65   $��
37,628,0,0q�6P   $	��Top=�6d   $��24(�6|   $��74��6�   $	��153��6�   ���	#FFEB0D0D$��4��6�   $��1��6�   �� 5'   
   -   5        $	 	btnUpdate��5'      $��Update��6$   $
��Left=�65   $��
94,630,0,0q�6P   $	��Top=�6d   $��24(�6|   $��73��6�   $	��168��6�   $ -0.014,0.481&�6�   ���	#FFE8EB0F$��4��6�   $��2��6�   �� 5(   
   -   5        $	 	btnDelete��5(      $��Delete��6$   $
��Left=�65   $��136,630,0,0q�6P   $	��Top=�6e   $��24(�6}   $��72��6�   $	��168��6�   ���	#FF0EC7DD$��5��6�   �� 5)   
   -	   5        $	 btnClose��5)      $��Close��6#   $
��Left=�63   $��309,630,0,0q�6N   $	��Top=�6c   $��24(�6{   $��73��6�   $	��168��6�   ���	#FFEBF2F3$��5��6�   $ 0.523,0.099&�6�   $��3��6  �� 5*   
   -
   5        $ txtDescription��5*      $
��Left=�6*   $��
44,260,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��555��6�   $��18(�6�   $��4��6�   $��4��6�   $��79��6�   5,      5-      