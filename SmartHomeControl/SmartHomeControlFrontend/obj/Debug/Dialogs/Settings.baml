   M S B A M L   `   `   `  ����  SmartHomeControlFrontend/    )SmartHomeControlFrontend.Dialogs.Settings   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ���	#FFB6BBFF$��16(�5	         
EncodeSans#��[  5
        � Title$  
Smart Home��5      $	��351��5       � WindowStartupLocation$ CenterScreen=�5       � AllowsTransparency .  � WindowStyle$
 None=�5       � 
ResizeMode$ NoResize=�5      $	��365��5      ��5      Z� .��5      �� -   5         ��Name$ windowBorder��5   	    �� CornerRadius$ 10��5   	   ���	#FF01053A J� RenderTransformOrigin$ 0.5,0.5&�5   	   $��24q�5   	    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      	   	Direction$		 270Q�5      
   
BlurRadius$
 20Q�5         Opacity$	 0.5Q�5      z�5   
   V� 5       .~�5!      �� -   5        windowScale��5!   !   5"      ._�5$   
   � .+�5%      ��  �� Orientation$ Vertical=�6   .+�5&      �� $ 	10,10,0,0��5'      $	��Top=�5(      ._�5)      � .+�5*      �� -   5         ��Name$ txt_windowTitle��5+      $��Einstellungen��5,      ���	#FFB6BBFF �� TextAlignment$ Center=�5.       �� Padding$ 0,8,0,0q�5/      50      �� 51      $ 
Horizontal=�52      $
��Left=�53      $	��Top=�54      $��	14,14,0,0q�55      .+�56      A� -   5         A�Name$ ell_closeWindow��56   &   $��0,0,4,0q�57   !     
redEllipse#��[ 58   !    � Triggers 5:   "   :� 5;   &    :� RoutedEvent$ Ellipse.MouseDown��63   .[�5<   *   �� .��5=   .   �� .��5>   2   W�  �� 
TargetName$ windowBorder��6B    �� TargetProperty$ (Border.Opacity)�6g    W� From$ 1X�6�   	 W� To$ 0X�6�    g� Duration$ 0:0:0.15D�6�   W� 5?   2   $ windowScale��6B   $ (ScaleTransform.ScaleY)�6f   $ 1X�6�   $	 0.5X�6�   $ 0:0:0.15D�6�   5@   /   5A   +   5B   '   5D      A� 5F        yellowEllipse#��[ 5G      {�.  $��0,0,4,0q�5I      A� 5K      -   5        $ ell_minimizeWindow��5K   &     greenEllipse#��[ 5L      $��0,0,4,0q�5M      6.   5N      5O      5P      �� 5R      $ Vertical=�6   $��16q�64   .+�5S      �� $��Broker-Adresse:��6    $
��Bold"�67   �� 5T      -   5         ��Name$ txt_brokerAddress��5T      $��0,8,0,0q�69   �� 5U      $��Broker-Port:��6    $
��Bold"�64   $��0,16,0,0q�6F   �� 5V      -   5        $ txt_brokerPort��5V      $��0,8,0,0q�66   �� 5W      $��Client-Name:��6    $
��Bold"�64   $��0,16,0,0q�6F   �� 5X      -   5        $ txt_clientName��5X      $��0,8,0,0q�66   �� 5Y      -	   5        $ txt_generateGuid��5Y       $��GUID generieren...��6:   $��Right=�6T   $��0,8,0,0q�6p    � Cursor$
 Hand��6�   5Z      �� 5\      -
   5         ��Name$ btn_save��5\      $
��Save��6+     
blueButton#��[ 6:   $��32��6^   $��Right=�6j   $��64��6�   $��0,0,16,0q�6�   6�   5]      5^       5`   
   :� 5a      $ Window.Loaded��6   .[�5b      �� .��5c      �� .��5d      W� $ windowBorder��6*   $ (Border.Opacity)�6O   $	 0.5X�6|   $ 1X�6�   $ 0:0:0.15D�6�   W� 5e      $ windowScale��6*   $ (ScaleTransform.ScaleY)�6N   $ 0X�6�   $ 1X�6�   $ 0:0:0.15D�6�   5f      5g      5h      :� 5i      $ Button.Click��6   .[�5j      �� .��5k      �� .��5l      W� $ windowBorder��6*   $ (Border.Opacity)�6O   $ 1X�6|   $	 0.5X�6�   $ 0:0:0.15D�6�   W� 5m      $ windowScale��6*   $ (ScaleTransform.ScaleY)�6N   $ 1X�6�   $ 0X�6�   $ 0:0:0.15D�6�   5n      5o      5p      5r      5s      