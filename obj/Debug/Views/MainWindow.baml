   M S B A M L   `   `   `  ����G  CClazyDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ClazyDesktopClazyDesktop  5   	   ?$clr-namespace:ClazyDesktop.UtilitiesClazyDesktop.Utilities  5
   
   [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms 5   	   ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration 5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   A%clr-namespace:ClazyDesktop.ViewModelsClazyDesktop.ViewModels  5   	       ClazyDesktop.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ClazyDesktop     5   	   7local2$clr-namespace:ClazyDesktop.Utilities     5
   
   Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	   dwinFormsOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration     5   	   9system&clr-namespace:System;assembly=mscorlib     5   	   <
viewModels%clr-namespace:ClazyDesktop.ViewModels     5   	   -   5          �Name$  MainWindowObj��5   	    � Title$ Clazy��5	   	   $	��670��6   $
��1034��6$    � Icon$M Gpack://application:,,,/ClazyDesktop;component/Resources/ClazyCircle.ico��5   	      CustomWindowStyle#��[  5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ CanMinimize=�5   	    � DataContext 5      +   %ClazyDesktop.ViewModels.MainViewModel  5   
    � 	Resources 5        NormalShadow F� ShadowDepth F� Softness	 F� Opacity 	 temps
 �� Type  CustomButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value �� 
TargetName��%  &	       &	 :     &	 �     F� 5   
   $ 2Q�66   $	 0.2Q�6F   $
	 0.64Q�6U   �� 5   
   "
 ��6    .s�5      ��	ello1��6#   ��5      	ello2��6#   ��5      	ello3��6#   ��5       	ello4��6#   5!      �� 5"   
   " ��6%   .�5#      ��  � �� �#ff6c376+   �� 5$       � ��
 �����6+   �� 5%       � ��$ 2q�60   �� 5&       � ��
 �   �6,   �� 5'       � �� 5(      �� 5)      " ��6&   .R�5*      �� $��border��6!   #��z��5+      #��z��5,      #��z��5-      ._�5.      �� $��Center=�6/   $��Center=�6L   5/       50      P� 51       �@J�IsMouseOver . . �52   "   �� $ border��6)    � ��
 �����6S   53      55      57      58      59      .��5=      �  � RowDefinitions 5@   
   �� 5A      $��3* �6   �� 5B      $��* �6    � ColumnDefinitions 5E   
   �� 5F      6!   �� 5G      6!   .+�5K   
   o� $	��Top=�6   .@�5L      m� $
��File��6   .@�5M      m� $��Open file maybe?��6    m� InputGestureText$ CTRL + O��65    m� Icon 5N      �� 5O      $��Resources/ClazyCircle.png��6     J� BitmapEffect 5P      F� 5Q   "   $ 1Q�69    F� Color$ Black��6I   $		 0.7Q�6W   5S      5U      m� 5V      $��Another menuitem��6   m� 5W      $��Another menuitem��6   m� 5X      $��Another menuitem��6   �� 5Y      m� 5Z      $��A disabled menu item��6   {�.  69   m� 5[      $��Another menuitem��6   m� 5\      $��Another menuitem��6   �� 5]      m� 5^      $��MenuItem with many others��6   5_      5`      m� 5a      $��Themes��6   .@�5b      m� $��Avaliable Themes Below��6   m� 5c      -   5        $��	Deep Dark��5c      
 J� Uid$ 0��6B    5d      �� 5e      ���	#FF232323���	#FF1B1B1B$��2��6H    �� StrokeLineJoin$ Round=�6\   # [ 6s   5g      m� 5h      -   5        $��Soft Dark (default)��5h      $ 1��6L    5i      �� 5j      ���	#FF404040���	#FF2A2A2A$��2��6H   $ Round=�6\   # [ 6s   5l      m� 5m      -   5        $��	Dark Grey��5m      $ 2��6B    5n      �� 5o      ���	#FF737373���	#FF4E4E4E$��2��6H   $ Round=�6\   # [ 6s   5q      m� 5r      -   5        $
��Grey��5r      $ 3��6=    5s      �� 5t      ���	#FFB3B3B3���	#FF797979$��2��6H   $ Round=�6\   # [ 6s   5v      m� 5w      -   5        $��Light��5w      $ 4��6>    5x      �� 5y      ���	#FF848484���	#FFE8E8E8$��2��6H   $ Round=�6\   # [ 6s   5{      m� 5|      -   5        $	��Red��5|      $ 5��6<    5}      �� 5~      ���	#FFFF1A1A���	#FFED1C1C$��2��6H   $ Round=�6\   # [ 6s   5�      5�      5�      �� 5�   
   $��0��6   $��2��6!   $	��Top=�65   $
��Left=�6M   $��30(�5�      $��Black"�6"   ���#ff6c37$��416,175,0,0q�5�   )   Project Name6L   �� 5�   
   -   5         ��Name$ txtbox��5�   
     MainFont#��[ 5�      $	��450��5�   
   $��50��5�   
   
�������
���   ����#3498db$��2q�5�   
   $	��Top=�5�   
   $
��Left=�5�   
   $��24(�5�   
   $��10q�5�   
   $��2��6   $��291,245,0,0q�6+   .��6@   .��5�   &   ��5�      �� 5�       �� Path$ YourProperty�6    �� Mode$ TwoWay=�6.    �� ValidationRules 5�      5�      .��5�      5�      �� 5�   
   $	��Top=�5�      $
��Left=�5�      #��[ 5�      $��
Import NWC��5�      #��[ 5�      $��2��5�      $	��250��5�      $��50��5�      $��24(�5�      $��391,343,0,0q�5�      ��5�      ��  �� ElementName$ txtbox��$
 Text���5�      �� *	InsertNwc+5�      �� 5�   
   $��	250,0,0,0q�6   $��1��5�      $��40��5�      
�������
�������$
��Next��5�      $��1��5�      $��20(�5�      $��	ExtraBold"�5�      #��[ 5�      ��5�      �� *NextCommand+��5�      �� $ MainWindowObj��6J   )   #ClazyDesktop.Utilities.DonutSpinner  5�   
       Duration$  0:0:1D�6   !   SpinnerColor
! ����$	��120��5�      $��40��6   $��2��6   $��1��64   y�5�      �� *IsSpinnerVisible+   BooleanToVisibilityConverter" �� 	Converter#" [ 5�      5�      