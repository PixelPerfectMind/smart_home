   M S B A M L   `   `   `  ����   SmartHomeControlFrontend/    )SmartHomeControlFrontend.Dialogs.Settings   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ���	#FFB6BBFF$��16(�   
EncodeSans#��[    � Title$  
Smart Home��$	��351�� � WindowStartupLocation$ CenterScreen=� � AllowsTransparency .  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�$	��392����Z� .���� -    ��Name$ windowBorder�� �� CornerRadius$ 10�����	#FF01053A J� RenderTransformOrigin$ 0.5,0.5&�$��24q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect  	   	Direction$		 270Q�
   
BlurRadius$
 20Q�   Opacity$	 0.5Q�z�V� .~��� -   windowScale��._�� .+���  �� Orientation$ Vertical=�.+��� $ 	10,10,0,0��$	��Top=�._�� .+��� -    ��Name$ txt_windowTitle��$��Einstellungen�����	#FFB6BBFF �� TextAlignment$ Center=� �� Padding$ 0,8,0,0q��� $ 
Horizontal=�$
��Left=�$	��Top=�$��	14,14,0,0q�.+�A� -    A�Name$ ell_closeWindow��$��0,0,4,0q�  
redEllipse#��[  � Triggers :�  :� RoutedEvent$ Ellipse.MouseDown��.[��� .���� .��W�  �� 
TargetName$ windowBorder�� �� TargetProperty$ (Border.Opacity)� W� From$ 1X�	 W� To$ 0X� g� Duration$ 0:0:0.15D�W� $ windowScale��$ (ScaleTransform.ScaleY)�$ 1X�$	 0.5X�$ 0:0:0.15D�A�   yellowEllipse#��[ {�.  $��0,0,4,0q�A� -   $ ell_minimizeWindow��  greenEllipse#��[ $��0,0,4,0q��� $ Vertical=�$��16q�.+��� $��Broker-Adresse:��$
��Bold"��� -    ��Name$ txt_brokerAddress��$��0,8,0,0q��� $��Broker-Port:��$
��Bold"�$��0,16,0,0q��� -   $ txt_brokerPort��$��0,8,0,0q��� $��Subscribe-Topic:��$
��Bold"�$��0,16,0,0q��� $:��4Leer lassen, falls kein Topic subscribed werden soll��$��0,4,0,0q�$��12(�$
��Wrap=��� -   $ txt_subscribeTopic��$��0,8,0,0q��� -	    ��Name$ btn_save��$
��Save��  
blueButton#��[ $��32��$��Right=�$��64��$��0,0,16,0q� :� $ Window.Loaded��.[��� .���� .��W� $ windowBorder��$ (Border.Opacity)�$	 0.5X�$ 1X�$ 0:0:0.15D�W� $ windowScale��$ (ScaleTransform.ScaleY)�$ 0X�$ 1X�$ 0:0:0.15D�:� $ Button.Click��.[��� .���� .��W� $ windowBorder��$ (Border.Opacity)�$ 1X�$	 0.5X�$ 0:0:0.15D�W� $ windowScale��$ (ScaleTransform.ScaleY)�$ 1X�$ 0X�$ 0:0:0.15D�