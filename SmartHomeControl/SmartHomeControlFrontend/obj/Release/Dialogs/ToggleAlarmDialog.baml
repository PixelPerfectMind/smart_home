   M S B A M L   `   `   `  ����   SmartHomeControlFrontend8    2SmartHomeControlFrontend.Dialogs.ToggleAlarmDialog   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ���	#FFB6BBFF$��16(�   
EncodeSans#��[    � Title$  
Smart Home��$	��437�� � WindowStartupLocation$ CenterScreen=� � AllowsTransparency .  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�$	��225����Z� .���� -    ��Name$ windowBorder�� �� CornerRadius$ 10�����	#FF01053A J� RenderTransformOrigin$ 0.5,0.5&�$��24q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect  	   	Direction$		 270Q�
   
BlurRadius$
 20Q�   Opacity$	 0.5Q�z�V� .~��� -   windowScale��._�� .+���  �� Orientation$ Vertical=�.+��� $ 	10,10,0,0��$	��Top=�._�� .+��� -    ��Name$ txt_windowTitle��$��Alarm auslösen?�����	#FFB6BBFF �� TextAlignment$ Center=� �� Padding$ 0,8,0,0q��� $ 
Horizontal=�$
��Left=�$	��Top=�$��	14,14,0,0q�.+�A� $��0,0,4,0q�{�.    
redEllipse#��[  � Triggers :�  :� RoutedEvent$ Ellipse.MouseDown��.[��� .���� .��W�  �� 
TargetName$ windowBorder�� �� TargetProperty$ (Border.Opacity)� W� From$ 1X�	 W� To$ 0X� g� Duration$ 0:0:0.15D�W� $ windowScale��$ (ScaleTransform.ScaleX)�$ 1X�$	 0.5X�$ 0:0:0.15D�W� $ windowScale��$ (ScaleTransform.ScaleY)�$ 1X�$	 0.5X�$ 0:0:0.15D�A�   yellowEllipse#��[ {�.  $��0,0,4,0q�A�   greenEllipse#��[ {�.  $��0,0,4,0q��� $ 
Horizontal=�$��16q�.+��� $'��!/Resources/Image/qestion-mark.png��$��68���� $K��EWollen Sie den Alarm auf ''ESP8266_ALARMANLAGE'' wirklich umschalten?��$
��Wrap=�$��	16,0,16,0q�$	��273���� $ 
Horizontal=�$��Right=�$��	0,0,16,16q�.+��� -    ��Name$ btn_no��$
��Nein��  normalButton#��[ $��32��$��48��$��0,0,8,0q��� -   $ btn_yes��$��Ja��  
blueButton#��[ $��32�� :� $ Window.Loaded��.[��� .���� .��W� $ windowBorder��$ (Border.Opacity)�$	 0.5X�$ 1X�$ 0:0:0.15D�W� $ windowScale��$ (ScaleTransform.ScaleY)�$ 0X�$ 1X�$ 0:0:0.15D�:� $ Button.Click��.[��� .���� .��W� $ windowBorder��$ (Border.Opacity)�$ 1X�$	 0.5X�$ 0:0:0.15D�W� $ windowScale��$ (ScaleTransform.ScaleY)�$ 1X�$ 0X�$ 0:0:0.15D�