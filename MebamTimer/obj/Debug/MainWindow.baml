   M S B A M L   `   `   `  ����E  AMebamTimer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MebamTimer
MebamTimer  5   	       MebamTimer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MebamTimer     5   	   -   5          � Title$  Mebam Timer��5   	   $��347.686��6   $��248.592��6.    � Left$ 0��6W   
 � Top$ 0��6`    � 
ResizeMode$ NoResize=�6h    � Topmost .  � Icon$ sand-clock.ico��6�   .��5	      � -   5         �Name$
 grid��5	       � ColumnDefinitions 5
   
   �� 5      $
��100* �6   �� 5      $
��141* �6   ��5   
   �� 5       �� ImageSource$ img/timer.jpg��6   	 j� Stretch$	 UniformToFill=�65   .+�5   
   �� $��Label��6   $��10,10,90.125,0q�6    $	��Top=�68   �� 5   
   -   5        
 ��Name$
 timeLbl��5      $��00:00:00��6!   $��Center=�64   $��	51,0,38,0q�6Q   $	��Top=�6d   $��36(�6|   $��2��6�   $	��154��6�   $��Yu Gothic UI Light)�6�   �� 5   
   -   5         ��Name$ 	baslatBtn��5      $��Başlat [F1]��6$   $
��Left=�6:   $��
10,267,0,0q�6U   $	��Top=�6i   $��80��6�   $��25��6�   $
��Bold"�6�    J� Opacity$	 0.8Q�6�   $��2q�6�   6�   �� 5   
   -   5        $ 	durdurBtn��5      $��Durdur [F2]��6$   $
��Left=�6:   $��
52,267,0,0q�6U   $	��Top=�6i   $��80��6�   $��25��6�   $
��Bold"�6�   $	 0.8Q�6�   $��2q�6�   $��1��6�   6�   �� 5   
   -   5        $
 alertLbl��5      $�� ��6"   $��Center=�6-   $��
51,46,-9,0q�6J   $	��Top=�6^    J� RenderTransformOrigin$ 1.149,-0.116&�6v   $��2��6�   $	��201��6�   $��16(�6�   ���	#FFCBC6C66�   5      5      