   M S B A M L   `   `   `  ����  SmartHomeControlFrontend2    ,SmartHomeControlFrontend.Dialogs.PopUpDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ���	#FFB6BBFF$��16(�5         
EncodeSans#��[  5	        � Title$  
Smart Home��5
      $	��437��5       � WindowStartupLocation$ CenterScreen=�5       � AllowsTransparency .  � WindowStyle$
 None=�5       � 
ResizeMode$ NoResize=�5      $	��225��5      ��5      Z� .��5      �� -   5         ��Name$ windowBorder��5   	    �� CornerRadius$ 10��5   	   ���	#FF01053A J� RenderTransformOrigin$ 0.5,0.5&�5   	   $��24q�5   	    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      	   	Direction$		 270Q�5      
   
BlurRadius$
 20Q�5         Opacity$	 0.5Q�5      z�5   
   V� 5      .~�5       �� -   5        windowScale��5    !   5!      ._�5#   
   � .+�5$      ��  �� Orientation$ Vertical=�6   .+�5%      �� $ 	10,10,0,0��5&      $	��Top=�5'      ._�5(      � .+�5)      �� -   5         ��Name$ txt_windowTitle��5*      $��Title��5+      ���	#FFB6BBFF �� TextAlignment$ Center=�5-       �� Padding$ 0,8,0,0q�5.      5/      �� 50      $ 
Horizontal=�51      $
��Left=�52      $	��Top=�53      $��	14,14,0,0q�54      .+�55      A� $��0,0,4,0q�56   !   {�.    
redEllipse#��[ 58   !    � Triggers 59   "   :� 5:   &    :� RoutedEvent$ Ellipse.MouseDown��63   .[�5;   *   �� .��5<   .   �� .��5=   2   W�  �� 
TargetName$ windowBorder��6B    �� TargetProperty$ (Border.Opacity)�6g    W� From$ 1X�6�   	 W� To$ 0X�6�    g� Duration$ 0:0:0.15D�6�   W� 5>   2   $ windowScale��6B   $ (ScaleTransform.ScaleX)�6f   $ 1X�6�   $	 0.5X�6�   $ 0:0:0.15D�6�   W� 5?   2   $ windowScale��6B   $ (ScaleTransform.ScaleY)�6f   $ 1X�6�   $	 0.5X�6�   $ 0:0:0.15D�6�   5@   /   5A   +   5B   '   5D      A� 5F        yellowEllipse#��[ 5G      {�.  $��0,0,4,0q�5I      A� 5K        greenEllipse#��[ 5L      {�.  $��0,0,4,0q�5N      5O      5P      5Q      �� 5S      $ 
Horizontal=�6   $��16q�66   .+�5T      �� -   5         ��Name$ 
img_symbol��5T      $'��!/Resources/Image/qestion-mark.png��60   $��68��6[   �� 5U      -   5        $ txt_message��5U       $)��#Do you want to confirm this action?��65   $
��Wrap=�6a   $��	16,0,16,0q�6u   $	��273��6�   $
��Left=�6�   $��Center=�6�   $
��Bold"�6�   5V      �� 5X      $ 
Horizontal=�6   $��Right=�66   $��	0,0,16,16q�6R   .+�5Y      �� -   5         ��Name$ btn_no��5Y      $��No��6-     normalButton#��[ 6:   $��32��6`   $��48��6l   $��0,0,8,0q�6w   6�   �� 5Z      -   5        $ btn_yes��5Z      $	��Yes��6.     
blueButton#��[ 6<   $��32��6`   $��48��6l   6w   5[      5\      5]       5_   
   :� 5`      $ Window.Loaded��6   .[�5a      �� .��5b      �� .��5c      W� $ windowBorder��6*   $ (Border.Opacity)�6O   $	 0.5X�6|   $ 1X�6�   $ 0:0:0.15D�6�   W� 5d      $ windowScale��6*   $ (ScaleTransform.ScaleY)�6N   $ 0X�6�   $ 1X�6�   $ 0:0:0.15D�6�   5e      5f      5g      :� 5h      $ Button.Click��6   .[�5i      �� .��5j      �� .��5k      W� $ windowBorder��6*   $ (Border.Opacity)�6O   $ 1X�6|   $	 0.5X�6�   $ 0:0:0.15D�6�   W� 5l      $ windowScale��6*   $ (ScaleTransform.ScaleY)�6N   $ 1X�6�   $ 0X�6�   $ 0:0:0.15D�6�   5m      5n      5o      5q      5r      