   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentationPresentation  5   	       Presentation.Orders   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentation     5   	     � Title$  Orders��5   	   $��400.000��6   $��500.000��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ btnBack��5
      $��< Back��6"   $
��Left=�66   $��21��6Q   $��
10,338,0,0q�6]   $	��Top=�6q   $��46��6�    J� RenderTransformOrigin$ 0.558,0.175&�6�   �� 5   
   -   5         ��Name$ 
listOrders��5      $
��Left=�6&   $	��214��6A   $��	10,45,0,0q�6N   $	��Top=�6a   $��80��6y   �� 5   
   -   5        $ listInfo��5      $
��Left=�6$   $	��214��6?   $��	95,45,0,0q�6L   $	��Top=�6_   $	��265��6w   �� 5   
   -   5        $ 
btnRefresh��5      $��Refresh Orders��6%   $
��Left=�6>   $��46��6Y   $��
10,264,0,0q�6e   $	��Top=�6y   $	��192��6�   6�   �� 5   
   -   5        $ 	btnCancle��5      $��Cancel Order��6$   $
��Left=�6<   $	��Top=�6W   $	��107��6o   $ 3.999,10.295&�6{   $��253,315,0,0q�6�   $��46��6�   6�   �� 5   
   -   5        $ btnComplete��5      $��Complete Order��6&   $
��Left=�6@   $	��Top=�6[   $	��107��6s   $��365,315,0,0q�6   $��46��6�   6�   �� 5   
   -   5        $ btnUp��5      $��priority Up��6    $
��Left=�66   $	��Top=�6Q   $	��107��6i   $��253,264,0,0q�6u   $��46��6�   6�   �� 5   
   -   5        $ btnDown��5      $��Priority Down��6"   $
��Left=�6:   $	��Top=�6U   $	��107��6m   $��365,264,0,0q�6y   $��46��6�   6�   �� 5   
   -	   5        $ 
listStatus��5      $
��Left=�6&   $	��216��6A   $	��Top=�6N   $	��111��6f   $��
365,45,0,0q�6r   $ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$
 0.27Q�6&   T� 5      5      5      �� 5   
   $��Order��6   $
��Left=�6    $	��Top=�6;   $��
210,14,0,0q�6S   �� 5   
   $��priority��6   $
��Left=�6#   $	��Top=�6>   $��	28,14,0,0q�6V   �� 5   
   $��Status��6   $
��Left=�6!   $��
400,14,0,0q�6<   $	��Top=�6P   $ 0.515,-0.127&�6h   5       5!      