object frmUHFReaderdemomain: TfrmUHFReaderdemomain
  Left = 106
  Top = 28
  BorderIcons = [biSystemMenu, biMinimize]
  BorderStyle = bsSingle
  Caption = 'UHFReader09 Demo Software v1.2'
  ClientHeight = 671
  ClientWidth = 828
  Color = clSilver
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  OnCloseQuery = FormCloseQuery
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object PageControl1: TPageControl
    Left = 0
    Top = 0
    Width = 828
    Height = 652
    ActivePage = TabSheet_CMD
    Align = alClient
    TabOrder = 0
    OnChange = PageControl1Change
    object TabSheet_CMD: TTabSheet
      Caption = 'Reader Parameter'
      object GroupBox_ReaderInfo: TGroupBox
        Left = 162
        Top = 10
        Width = 649
        Height = 119
        Caption = 'Reader Information'
        TabOrder = 1
        object Label2: TLabel
          Left = 181
          Top = 24
          Width = 38
          Height = 13
          Caption = 'Version:'
        end
        object Label3: TLabel
          Left = 10
          Top = 58
          Width = 41
          Height = 13
          Caption = 'Address:'
        end
        object Label4: TLabel
          Left = 368
          Top = 58
          Width = 118
          Height = 13
          Caption = 'Max InventoryScanTime:'
        end
        object Label10: TLabel
          Left = 10
          Top = 24
          Width = 27
          Height = 13
          Caption = 'Type:'
        end
        object Label11: TLabel
          Left = 368
          Top = 24
          Width = 36
          Height = 13
          Caption = 'Protocl:'
        end
        object Label8: TLabel
          Left = 179
          Top = 58
          Width = 33
          Height = 13
          Caption = 'Power:'
        end
        object Label13: TLabel
          Left = 179
          Top = 92
          Width = 76
          Height = 13
          Caption = 'Max.Frequency:'
        end
        object Label14: TLabel
          Left = 10
          Top = 92
          Width = 73
          Height = 13
          Caption = 'Min.Frequency:'
        end
        object Edit_Version: TEdit
          Left = 257
          Top = 20
          Width = 96
          Height = 21
          Color = clSilver
          ImeName = #20013#25991' ('#31616#20307') - '#24494#36719#25340#38899
          ReadOnly = True
          TabOrder = 2
        end
        object Edit_ComAdr: TEdit
          Left = 85
          Top = 54
          Width = 81
          Height = 21
          Color = clSilver
          ImeName = #20013#25991' ('#31616#20307') - '#24494#36719#25340#38899
          ReadOnly = True
          TabOrder = 4
        end
        object Edit_scantime: TEdit
          Left = 496
          Top = 54
          Width = 129
          Height = 21
          Color = clSilver
          ImeName = #20013#25991' ('#31616#20307') - '#24494#36719#25340#38899
          ReadOnly = True
          TabOrder = 6
        end
        object Edit_Type: TEdit
          Left = 85
          Top = 20
          Width = 81
          Height = 21
          Color = clSilver
          ImeName = #20013#25991' ('#31616#20307') - '#24494#36719#25340#38899
          ReadOnly = True
          TabOrder = 1
        end
        object Button3: TButton
          Left = 496
          Top = 85
          Width = 129
          Height = 25
          Action = Action_GetReaderInformation
          Caption = 'Get Reader Info'
          TabOrder = 7
        end
        object Edit_dmaxfre: TEdit
          Left = 257
          Top = 88
          Width = 96
          Height = 21
          Color = clSilver
          ImeName = #20013#25991' ('#31616#20307') - '#24494#36719#25340#38899
          ReadOnly = True
          TabOrder = 9
        end
        object Edit_dminfre: TEdit
          Left = 85
          Top = 88
          Width = 81
          Height = 21
          Color = clSilver
          ImeName = #20013#25991' ('#31616#20307') - '#24494#36719#25340#38899
          ReadOnly = True
          TabOrder = 8
        end
        object Edit_powerdBm: TEdit
          Left = 257
          Top = 54
          Width = 96
          Height = 21
          Color = clSilver
          ImeName = #20013#25991' ('#31616#20307') - '#24494#36719#25340#38899
          ReadOnly = True
          TabOrder = 5
        end
        object EPCC1G2: TCheckBox
          Left = 496
          Top = 30
          Width = 73
          Height = 17
          BiDiMode = bdLeftToRight
          Caption = 'EPCC1-G2'
          ParentBiDiMode = False
          TabOrder = 3
        end
        object ISO180006B: TCheckBox
          Left = 496
          Top = 14
          Width = 89
          Height = 17
          BiDiMode = bdLeftToRight
          Caption = 'ISO18000-6B'
          ParentBiDiMode = False
          TabOrder = 0
        end
      end
      object GroupBox_COM: TGroupBox
        Left = 8
        Top = 10
        Width = 141
        Height = 223
        Caption = 'Communication'
        TabOrder = 0
        object Label6: TLabel
          Left = 14
          Top = 24
          Width = 46
          Height = 13
          Caption = 'COM Port'
        end
        object Label12: TLabel
          Left = 14
          Top = 145
          Width = 87
          Height = 13
          Caption = 'Opened COM Port'
        end
        object Label46: TLabel
          Left = 16
          Top = 105
          Width = 37
          Height = 13
          Caption = 'Baud'#65306
        end
        object ComboBox_COM: TComboBox
          Left = 65
          Top = 21
          Width = 63
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          TabOrder = 0
          OnChange = ComboBox_COMChange
        end
        object Button2: TButton
          Left = 14
          Top = 76
          Width = 112
          Height = 25
          Action = Action_OpenCOM
          Caption = 'Open COM Port'
          TabOrder = 3
        end
        object Button4: TButton
          Left = 14
          Top = 189
          Width = 112
          Height = 25
          Action = Action_CloseCOM
          Caption = 'Close COM Port'
          TabOrder = 5
        end
        object StaticText1: TStaticText
          Left = 14
          Top = 51
          Width = 83
          Height = 17
          Caption = 'Reader Address:'
          TabOrder = 2
        end
        object Edit_CmdComAddr: TEdit
          Left = 98
          Top = 48
          Width = 28
          Height = 21
          CharCase = ecUpperCase
          MaxLength = 2
          TabOrder = 1
          Text = 'FF'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object ComboBox_AlreadyOpenCOM: TComboBox
          Left = 14
          Top = 162
          Width = 113
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          TabOrder = 4
          OnCloseUp = ComboBox_AlreadyOpenCOMCloseUp
        end
        object ComboBox_baud2: TComboBox
          Left = 13
          Top = 119
          Width = 113
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          TabOrder = 6
          Items.Strings = (
            '9600bps'
            '19200bps'
            '38400bps'
            '57600bps'
            '115200bps')
        end
      end
      object GroupBox2: TGroupBox
        Left = 161
        Top = 136
        Width = 650
        Height = 148
        Caption = 'Set Reader Parameter'
        TabOrder = 2
        object Label15: TLabel
          Left = 8
          Top = 88
          Width = 73
          Height = 13
          Caption = 'Min.Frequency:'
        end
        object Label16: TLabel
          Left = 8
          Top = 119
          Width = 76
          Height = 13
          Caption = 'Max.Frequency:'
        end
        object Label17: TLabel
          Left = 208
          Top = 24
          Width = 54
          Height = 13
          Caption = 'Baud Rate:'
        end
        object Label1: TLabel
          Left = 8
          Top = 26
          Width = 69
          Height = 13
          Caption = 'Address(HEX):'
        end
        object Label7: TLabel
          Left = 8
          Top = 57
          Width = 33
          Height = 13
          Caption = 'Power:'
        end
        object Label5: TLabel
          Left = 208
          Top = 57
          Width = 118
          Height = 13
          Caption = 'Max InventoryScanTime:'
        end
        object Button5: TButton
          Left = 336
          Top = 117
          Width = 129
          Height = 25
          Action = Action_SetReaderInformation
          Caption = 'Set Parameter'
          TabOrder = 6
        end
        object ComboBox_baud: TComboBox
          Left = 336
          Top = 22
          Width = 129
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          TabOrder = 1
          Items.Strings = (
            '9600bps'
            '19200bps'
            '38400bps'
            '57600bps'
            '115200bps')
        end
        object Edit_NewComAdr: TEdit
          Left = 86
          Top = 22
          Width = 113
          Height = 21
          MaxLength = 2
          TabOrder = 0
          Text = '00'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object ComboBox_scantime: TComboBox
          Left = 336
          Top = 53
          Width = 129
          Height = 21
          Style = csDropDownList
          ImeName = #20013#25991' ('#31616#20307') - '#24494#36719#25340#38899
          ItemHeight = 13
          TabOrder = 3
        end
        object Button1: TButton
          Left = 497
          Top = 117
          Width = 129
          Height = 25
          Action = Action_SetReaderInformation_0
          Caption = 'Default Parameter'
          TabOrder = 7
        end
        object ComboBox_dminfre: TComboBox
          Left = 86
          Top = 84
          Width = 113
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          TabOrder = 4
          OnSelect = ComboBox_dfreSelect
        end
        object ComboBox_dmaxfre: TComboBox
          Tag = 1
          Left = 86
          Top = 115
          Width = 113
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          TabOrder = 8
          OnSelect = ComboBox_dfreSelect
        end
        object ComboBox_PowerDbm: TComboBox
          Left = 86
          Top = 53
          Width = 113
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          TabOrder = 2
          Items.Strings = (
            '0'
            '1'
            '2'
            '3'
            '4'
            '5'
            '6'
            '7'
            '8'
            '9'
            '10'
            '11'
            '12'
            '13')
        end
        object CheckBox_SameFre: TCheckBox
          Left = 208
          Top = 88
          Width = 145
          Height = 17
          Caption = 'Single Frequency Point '
          TabOrder = 5
          OnClick = CheckBox_SameFreClick
        end
        object GroupBox3: TGroupBox
          Left = 472
          Top = 16
          Width = 153
          Height = 99
          Caption = 'Band Select'
          TabOrder = 9
          object RadioButton_band1: TRadioButton
            Left = 8
            Top = 12
            Width = 113
            Height = 17
            Caption = 'User band'
            TabOrder = 0
            OnClick = RadioButton_band1Click
          end
          object RadioButton_band2: TRadioButton
            Left = 8
            Top = 28
            Width = 113
            Height = 17
            Caption = 'Chinese band2'
            TabOrder = 1
            OnClick = RadioButton_band2Click
          end
          object RadioButton_band3: TRadioButton
            Left = 8
            Top = 44
            Width = 113
            Height = 17
            Caption = 'US band'
            TabOrder = 2
            OnClick = RadioButton_band3Click
          end
          object RadioButton_band4: TRadioButton
            Left = 8
            Top = 60
            Width = 113
            Height = 17
            Caption = 'Korean band'
            TabOrder = 3
            OnClick = RadioButton_band4Click
          end
          object RadioButton_band5: TRadioButton
            Left = 8
            Top = 77
            Width = 113
            Height = 17
            Caption = 'EU band'
            TabOrder = 4
            OnClick = RadioButton_band5Click
          end
        end
      end
    end
    object TabSheet_EPCC1G2: TTabSheet
      Caption = 'EPCC1-G2 Test'
      ImageIndex = 1
      object GroupBox5: TGroupBox
        Left = 8
        Top = 443
        Width = 481
        Height = 177
        Caption = 'Set Protect For Reading Or Writing'
        TabOrder = 7
        object Label24: TLabel
          Left = 267
          Top = 131
          Width = 124
          Height = 13
          Caption = 'Access Password (8 Hex):'
        end
        object ComboBox_EPC1: TComboBox
          Tag = 1
          Left = 8
          Top = 18
          Width = 249
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          TabOrder = 1
        end
        object Button_SetProtectState: TButton
          Left = 376
          Top = 145
          Width = 97
          Height = 25
          Action = Action_SetProtectState
          Caption = 'Set Protect'
          TabOrder = 4
        end
        object Edit_AccessCode1: TEdit
          Left = 267
          Top = 148
          Width = 91
          Height = 21
          MaxLength = 8
          TabOrder = 5
          Text = '00000000'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object GroupBox1: TGroupBox
          Left = 268
          Top = 10
          Width = 206
          Height = 31
          TabOrder = 0
          object P_Reserve: TRadioButton
            Left = 3
            Top = 8
            Width = 68
            Height = 17
            Caption = 'Password'
            TabOrder = 0
          end
          object P_EPC: TRadioButton
            Left = 73
            Top = 8
            Width = 42
            Height = 17
            Caption = 'EPC'
            TabOrder = 1
          end
          object P_TID: TRadioButton
            Left = 115
            Top = 8
            Width = 38
            Height = 17
            Caption = 'TID'
            TabOrder = 2
          end
          object P_User: TRadioButton
            Left = 154
            Top = 8
            Width = 44
            Height = 17
            Caption = 'User'
            TabOrder = 3
          end
        end
        object GroupBox16: TGroupBox
          Left = 8
          Top = 43
          Width = 248
          Height = 125
          Caption = 'Lock of Password'
          TabOrder = 2
          object GroupBox4: TGroupBox
            Left = 5
            Top = 11
            Width = 196
            Height = 34
            TabOrder = 0
            object DestroyCode: TRadioButton
              Left = 5
              Top = 10
              Width = 84
              Height = 17
              Caption = 'Kill Password'
              TabOrder = 0
            end
            object AccessCode: TRadioButton
              Left = 88
              Top = 10
              Width = 106
              Height = 17
              Caption = 'Access Password'
              TabOrder = 1
            end
          end
          object NoProect: TRadioButton
            Left = 5
            Top = 47
            Width = 203
            Height = 17
            Caption = 'Readable and  writeable from any state'
            TabOrder = 1
          end
          object Always: TRadioButton
            Left = 5
            Top = 80
            Width = 192
            Height = 17
            Caption = 'Permanently readable and writeable'
            TabOrder = 3
          end
          object Proect: TRadioButton
            Left = 5
            Top = 63
            Width = 239
            Height = 17
            Caption = 'Readable and writeable from the secured state'
            TabOrder = 2
          end
          object AlwaysNot: TRadioButton
            Left = 5
            Top = 97
            Width = 169
            Height = 17
            Caption = 'Never readable and writeable'
            TabOrder = 4
          end
        end
        object GroupBox18: TGroupBox
          Left = 267
          Top = 43
          Width = 207
          Height = 86
          Caption = 'Lock of EPC TID and User Bank'
          TabOrder = 3
          object NoProect2: TRadioButton
            Left = 8
            Top = 16
            Width = 151
            Height = 17
            Caption = 'Writeable from any state'
            TabOrder = 0
          end
          object AlwaysNot2: TRadioButton
            Left = 8
            Top = 67
            Width = 113
            Height = 17
            Caption = 'Never writeable'
            TabOrder = 3
          end
          object Proect2: TRadioButton
            Left = 8
            Top = 33
            Width = 184
            Height = 17
            Caption = 'Writeable from the secured state'
            TabOrder = 1
          end
          object Always2: TRadioButton
            Left = 8
            Top = 50
            Width = 113
            Height = 17
            Caption = 'Permanently writeable'
            TabOrder = 2
          end
        end
      end
      object GroupBox9: TGroupBox
        Left = 498
        Top = 52
        Width = 319
        Height = 77
        Caption = 'Kill Tag'
        TabOrder = 2
        object Label33: TLabel
          Left = 16
          Top = 41
          Width = 62
          Height = 26
          Caption = 'Kill Password'#13#10'(8 Hex):'
        end
        object Button_DestroyCard: TButton
          Left = 224
          Top = 45
          Width = 81
          Height = 23
          Action = Action_DestroyCard
          Caption = 'Kill Tag'
          TabOrder = 2
        end
        object Edit_DestroyCode: TEdit
          Left = 119
          Top = 45
          Width = 78
          Height = 21
          MaxLength = 8
          TabOrder = 1
          Text = '00000000'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object ComboBox_EPC3: TComboBox
          Tag = 3
          Left = 10
          Top = 16
          Width = 295
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          TabOrder = 0
        end
      end
      object GroupBox10: TGroupBox
        Left = 8
        Top = 233
        Width = 481
        Height = 208
        Caption = 'Read Data / Write Data / Block Erase'
        TabOrder = 4
        object Label9: TLabel
          Left = 8
          Top = 130
          Width = 124
          Height = 13
          Caption = 'Access Password (8 Hex):'
        end
        object Label18: TLabel
          Left = 8
          Top = 157
          Width = 82
          Height = 13
          Caption = 'Write Data (Hex):'
        end
        object Label19: TLabel
          Left = 8
          Top = 76
          Width = 157
          Height = 13
          Caption = 'Address of Tag Data(Word/Hex):'
        end
        object Label20: TLabel
          Left = 8
          Top = 97
          Width = 165
          Height = 26
          Caption = 'Length of Data(Read/Block Erase)'#13#10'(0-120/Word/D):'
        end
        object SpeedButton_Read_G2: TSpeedButton
          Left = 8
          Top = 177
          Width = 37
          Height = 24
          AllowAllUp = True
          GroupIndex = 5
          Caption = 'Read'
          OnClick = SpeedButton_Read_G2Click
        end
        object ComboBox_EPC2: TComboBox
          Tag = 2
          Left = 8
          Top = 16
          Width = 265
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          TabOrder = 1
        end
        object Edit_AccessCode2: TEdit
          Left = 144
          Top = 126
          Width = 129
          Height = 21
          MaxLength = 8
          TabOrder = 5
          Text = '00000000'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object Edit_WriteData: TEdit
          Left = 96
          Top = 153
          Width = 177
          Height = 21
          TabOrder = 6
          Text = '0000'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object Edit_WordPtr: TEdit
          Left = 186
          Top = 73
          Width = 87
          Height = 21
          MaxLength = 2
          TabOrder = 3
          Text = '00'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object Edit_Len: TEdit
          Left = 186
          Top = 99
          Width = 87
          Height = 21
          MaxLength = 3
          TabOrder = 4
          Text = '4'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object Memo_DataShow: TMemo
          Left = 279
          Top = 15
          Width = 194
          Height = 185
          ScrollBars = ssVertical
          TabOrder = 0
        end
        object GroupBox6: TGroupBox
          Left = 8
          Top = 37
          Width = 265
          Height = 32
          TabOrder = 2
          object C_Reserve: TRadioButton
            Left = 2
            Top = 10
            Width = 65
            Height = 17
            Caption = 'Password'
            TabOrder = 0
          end
          object C_EPC: TRadioButton
            Left = 71
            Top = 10
            Width = 57
            Height = 17
            Caption = 'EPC'
            TabOrder = 1
          end
          object C_TID: TRadioButton
            Left = 131
            Top = 10
            Width = 56
            Height = 17
            Caption = 'TID'
            TabOrder = 2
          end
          object C_User: TRadioButton
            Left = 192
            Top = 10
            Width = 65
            Height = 17
            Caption = 'User'
            TabOrder = 3
          end
        end
        object Button16: TButton
          Left = 232
          Top = 177
          Width = 42
          Height = 24
          Caption = 'Clear'
          TabOrder = 9
          OnClick = Button16Click
        end
        object Button_DataWrite: TButton
          Left = 50
          Top = 177
          Width = 37
          Height = 24
          Action = Action_ShowOrChangeData_write
          Caption = 'Write'
          TabOrder = 7
        end
        object Button_BlockErase: TButton
          Left = 159
          Top = 177
          Width = 68
          Height = 24
          Action = Action_ShowOrChangeData_BlockErase
          Caption = 'Block Erase'
          TabOrder = 8
        end
        object Button_writeblock: TButton
          Left = 91
          Top = 177
          Width = 62
          Height = 25
          Caption = 'Block Write'
          TabOrder = 10
          OnClick = Button_writeblockClick
        end
      end
      object GroupBox11: TGroupBox
        Left = 8
        Top = 0
        Width = 480
        Height = 177
        Caption = 'List EPC of Tags'
        TabOrder = 0
        object ListView_EPC: TListView
          Left = 8
          Top = 16
          Width = 465
          Height = 162
          Columns = <
            item
              Caption = 'No.'
            end
            item
              Caption = 'ID'
              Width = 270
            end
            item
              Caption = 'EPC Length'
              Width = 70
            end
            item
              Caption = 'Times'
            end>
          GridLines = True
          TabOrder = 0
          ViewStyle = vsReport
        end
      end
      object GroupBox17: TGroupBox
        Left = 498
        Top = 0
        Width = 319
        Height = 51
        Caption = 'Query Tag'
        TabOrder = 1
        object Label25: TLabel
          Left = 16
          Top = 21
          Width = 67
          Height = 13
          Caption = 'Read Interval:'
        end
        object SpeedButton_Query: TSpeedButton
          Left = 224
          Top = 15
          Width = 81
          Height = 25
          AllowAllUp = True
          GroupIndex = 1
          Caption = 'Query Tag'
          OnClick = Action_OpenTestModeExecute
        end
        object ComboBox_IntervalTime: TComboBox
          Left = 119
          Top = 17
          Width = 97
          Height = 21
          ItemHeight = 13
          TabOrder = 0
          OnChange = ComboBox_IntervalTimeChange
        end
      end
      object GroupBox20: TGroupBox
        Left = 498
        Top = 211
        Width = 319
        Height = 193
        Caption = 'Read Protection'
        TabOrder = 5
        object Label32: TLabel
          Left = 16
          Top = 38
          Width = 84
          Height = 26
          Caption = 'Access Password'#13#10'(8 Hex):'
        end
        object ComboBox_EPC4: TComboBox
          Tag = 3
          Left = 10
          Top = 14
          Width = 295
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          TabOrder = 0
        end
        object Edit_AccessCode4: TEdit
          Left = 119
          Top = 40
          Width = 78
          Height = 21
          MaxLength = 8
          TabOrder = 1
          Text = '00000000'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object Button_SetReadProtect_G2: TButton
          Left = 16
          Top = 71
          Width = 289
          Height = 25
          Action = Action_SetReadProtect_G2
          Caption = 'Set Single Tag Read Protection'
          TabOrder = 2
        end
        object Button_SetMultiReadProtect_G2: TButton
          Left = 16
          Top = 100
          Width = 289
          Height = 25
          Action = Action_SetMultiReadProtect_G2
          Caption = 'Set Single Tag Read Protection without EPC'
          TabOrder = 3
        end
        object Button_RemoveReadProtect_G2: TButton
          Left = 16
          Top = 131
          Width = 289
          Height = 25
          Action = Action_RemoveReadProtect_G2
          Caption = 'Reset Single Tag Read Protection without EPC'
          TabOrder = 4
        end
        object Button_CheckReadProtected_G2: TButton
          Left = 16
          Top = 162
          Width = 289
          Height = 25
          Action = Action_CheckReadProtected_G2
          Caption = 'Detect Single Tag Read Protection without EPC Password'
          TabOrder = 5
        end
      end
      object GroupBox21: TGroupBox
        Left = 498
        Top = 407
        Width = 319
        Height = 112
        Caption = 'EAS Alarm'
        TabOrder = 6
        object Label_Alarm: TLabel
          Left = 216
          Top = 39
          Width = 30
          Height = 30
          Caption = #9679
          Color = clBtnFace
          Font.Charset = GB2312_CHARSET
          Font.Color = clRed
          Font.Height = -30
          Font.Name = 'MS Sans Serif'
          Font.Style = []
          ParentColor = False
          ParentFont = False
          Visible = False
        end
        object Label35: TLabel
          Left = 16
          Top = 39
          Width = 84
          Height = 26
          Caption = 'Access Password'#13#10'(8 Hex):'
        end
        object SpeedButton_CheckAlarm_G2: TSpeedButton
          Left = 224
          Top = 75
          Width = 81
          Height = 25
          AllowAllUp = True
          GroupIndex = 3
          Caption = 'Check Alarm'
          OnClick = Action_CheckEASAlarm_G2Execute
        end
        object Button_SetEASAlarm_G2: TButton
          Left = 119
          Top = 75
          Width = 81
          Height = 25
          Action = Action_SetEASAlarm_G2
          Caption = 'Alarm Setting'
          TabOrder = 3
        end
        object ComboBox_EPC5: TComboBox
          Tag = 3
          Left = 10
          Top = 15
          Width = 295
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          TabOrder = 0
        end
        object Edit_AccessCode5: TEdit
          Left = 119
          Top = 42
          Width = 78
          Height = 21
          MaxLength = 8
          TabOrder = 1
          Text = '00000000'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object GroupBox24: TGroupBox
          Left = 16
          Top = 65
          Width = 81
          Height = 43
          TabOrder = 2
          object Alarm_G2: TRadioButton
            Left = 5
            Top = 8
            Width = 57
            Height = 17
            Caption = 'Alarm'
            TabOrder = 0
          end
          object NoAlarm_G2: TRadioButton
            Left = 5
            Top = 24
            Width = 65
            Height = 17
            Caption = 'No Alarm'
            TabOrder = 1
          end
        end
      end
      object GroupBox22: TGroupBox
        Left = 498
        Top = 522
        Width = 319
        Height = 99
        Caption = 'Lock Block for User (Permanently Lock)'
        TabOrder = 8
        object Label36: TLabel
          Left = 16
          Top = 41
          Width = 98
          Height = 26
          Caption = 'Address of Tag Data'#13#10'(Word):'
        end
        object Label37: TLabel
          Left = 16
          Top = 65
          Width = 84
          Height = 26
          Caption = 'Access Password'#13#10'(8 Hex):'
        end
        object Button_LockUserBlock_G2: TButton
          Left = 224
          Top = 66
          Width = 81
          Height = 25
          Action = Action_LockUserBlock_G2
          Caption = 'Lock'
          TabOrder = 2
        end
        object ComboBox_BlockNum: TComboBox
          Left = 119
          Top = 44
          Width = 81
          Height = 21
          ItemHeight = 13
          TabOrder = 1
        end
        object ComboBox_EPC6: TComboBox
          Tag = 3
          Left = 10
          Top = 18
          Width = 295
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          TabOrder = 0
        end
        object Edit_AccessCode6: TEdit
          Left = 119
          Top = 70
          Width = 78
          Height = 21
          MaxLength = 8
          TabOrder = 3
          Text = '00000000'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
      end
      object GroupBox23: TGroupBox
        Left = 498
        Top = 130
        Width = 319
        Height = 80
        Caption = 'Write EPC(Random write one tag in the antenna)'
        TabOrder = 3
        object Label38: TLabel
          Left = 16
          Top = 43
          Width = 84
          Height = 26
          Caption = 'Access Password'#13#10'(8 Hex):'
        end
        object Label39: TLabel
          Left = 8
          Top = 16
          Width = 53
          Height = 26
          Caption = 'Write EPC:'#13#10'(1-15Word)'
        end
        object Edit_AccessCode3: TEdit
          Left = 119
          Top = 48
          Width = 78
          Height = 21
          MaxLength = 8
          TabOrder = 2
          Text = '00000000'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object Button_WriteEPC_G2: TButton
          Left = 224
          Top = 43
          Width = 81
          Height = 25
          Action = Action_WriteEPC_G2
          Caption = 'Write EPC'
          TabOrder = 1
        end
        object Edit_WriteEPC: TEdit
          Left = 61
          Top = 16
          Width = 244
          Height = 21
          MaxLength = 60
          TabOrder = 0
          Text = '0000'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
      end
      object GroupBox29: TGroupBox
        Left = 8
        Top = 181
        Width = 481
        Height = 50
        Caption = 'EPC Mask Enabled'
        TabOrder = 9
        object Label42: TLabel
          Left = 120
          Top = 25
          Width = 44
          Height = 13
          Caption = 'Maskadr:'
        end
        object Label43: TLabel
          Left = 320
          Top = 25
          Width = 47
          Height = 13
          Caption = 'MaskLen:'
        end
        object CheckBox1: TCheckBox
          Left = 8
          Top = 24
          Width = 65
          Height = 17
          Caption = 'Enabled'
          TabOrder = 0
        end
        object Edit2: TEdit
          Left = 168
          Top = 18
          Width = 105
          Height = 21
          TabOrder = 1
          Text = '00'
        end
        object Edit3: TEdit
          Left = 368
          Top = 18
          Width = 105
          Height = 21
          TabOrder = 2
          Text = '00'
        end
      end
    end
    object TabSheet_6B: TTabSheet
      Caption = '18000-6B Test'
      ImageIndex = 2
      object GroupBox12: TGroupBox
        Left = 8
        Top = 4
        Width = 801
        Height = 309
        Caption = 'List ID of Tags'
        TabOrder = 0
        object ListView_ID_6B: TListView
          Left = 8
          Top = 16
          Width = 780
          Height = 282
          Columns = <
            item
              Caption = 'No.'
            end
            item
              Caption = 'ID'
              Width = 600
            end
            item
              Caption = 'Times'
              Width = 80
            end>
          GridLines = True
          TabOrder = 0
          ViewStyle = vsReport
        end
      end
      object GroupBox13: TGroupBox
        Left = 336
        Top = 316
        Width = 473
        Height = 304
        Caption = 
          'Read and Write Data Block / Permanently Write  Protect Block of ' +
          ' byte'
        TabOrder = 2
        object Label29: TLabel
          Left = 9
          Top = 90
          Width = 165
          Height = 13
          Caption = 'Write Data (1-32 Byte/Hex):           '
        end
        object Label30: TLabel
          Left = 9
          Top = 49
          Width = 102
          Height = 26
          Caption = 'Start/Protect Address'#13#10'(00-E9)(Hex):   '
        end
        object Label31: TLabel
          Left = 237
          Top = 49
          Width = 84
          Height = 26
          Caption = 'Length of Data:'#13#10'(1-32/Byte/D)      '
        end
        object SpeedButton_Read_6B: TSpeedButton
          Left = 8
          Top = 117
          Width = 49
          Height = 25
          AllowAllUp = True
          GroupIndex = 5
          Caption = 'Read'
          OnClick = SpeedButton_ReadWrite_6BClick
        end
        object SpeedButton_Write_6B: TSpeedButton
          Left = 78
          Top = 117
          Width = 49
          Height = 25
          AllowAllUp = True
          GroupIndex = 5
          Caption = 'Write'
          OnClick = SpeedButton_ReadWrite_6BClick
        end
        object ComboBox_ID1_6B: TComboBox
          Tag = 2
          Left = 9
          Top = 20
          Width = 453
          Height = 21
          Style = csDropDownList
          ItemHeight = 13
          TabOrder = 2
        end
        object Edit_WriteData_6B: TEdit
          Left = 156
          Top = 85
          Width = 305
          Height = 21
          TabOrder = 5
          Text = '0000'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object Edit_StartAddress_6B: TEdit
          Left = 117
          Top = 54
          Width = 110
          Height = 21
          MaxLength = 2
          TabOrder = 3
          Text = '00'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object Edit_Len_6B: TEdit
          Left = 320
          Top = 54
          Width = 141
          Height = 21
          MaxLength = 2
          TabOrder = 4
          Text = '12'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object Button11: TButton
          Left = 273
          Top = 13
          Width = 56
          Height = 25
          Action = Action_ReadData_6B
          Caption = 'Read'
          TabOrder = 0
          Visible = False
        end
        object Memo_DataShow_6B: TMemo
          Left = 8
          Top = 152
          Width = 452
          Height = 143
          ScrollBars = ssVertical
          TabOrder = 9
        end
        object Button12: TButton
          Left = 342
          Top = 13
          Width = 54
          Height = 25
          Action = Action_WriteData_6B
          Caption = 'Write'
          TabOrder = 1
          Visible = False
        end
        object Button14: TButton
          Left = 148
          Top = 117
          Width = 139
          Height = 25
          Action = Action_LockByte_6B
          Caption = 'Permanently Write  Protect'
          TabOrder = 6
        end
        object Button15: TButton
          Left = 307
          Top = 117
          Width = 81
          Height = 25
          Action = Action_CheckLock_6B
          Caption = 'Check Protect'
          TabOrder = 7
        end
        object Button22: TButton
          Left = 408
          Top = 117
          Width = 52
          Height = 25
          Caption = 'Clear'
          TabOrder = 8
          OnClick = Button22Click
        end
      end
      object GroupBox14: TGroupBox
        Left = 8
        Top = 452
        Width = 321
        Height = 168
        Caption = 'Query Tags by Condition'
        TabOrder = 3
        object Label34: TLabel
          Left = 8
          Top = 132
          Width = 133
          Height = 13
          Caption = 'Condition(<=8 Hex Number):'
        end
        object Label28: TLabel
          Left = 8
          Top = 92
          Width = 134
          Height = 13
          Caption = 'Address of Tag Data(0-223):'
        end
        object Edit_Query_StartAddress_6B: TEdit
          Left = 160
          Top = 87
          Width = 97
          Height = 21
          MaxLength = 3
          TabOrder = 4
          Text = '0'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object Edit_ConditionContent_6B: TEdit
          Left = 160
          Top = 124
          Width = 97
          Height = 21
          MaxLength = 16
          TabOrder = 5
          Text = '00'
          OnKeyPress = Edit_NewComAdrKeyPress
        end
        object Less_6B: TRadioButton
          Left = 8
          Top = 56
          Width = 129
          Height = 17
          Caption = 'Less than Condition'
          TabOrder = 2
        end
        object Different_6B: TRadioButton
          Left = 160
          Top = 24
          Width = 113
          Height = 17
          Caption = 'Unequal Condition'
          TabOrder = 1
        end
        object Same_6B: TRadioButton
          Left = 8
          Top = 24
          Width = 113
          Height = 17
          Caption = 'Equal Condition'
          TabOrder = 0
        end
        object Greater_6B: TRadioButton
          Left = 160
          Top = 56
          Width = 81
          Height = 17
          Caption = 'Greater than Condition'
          TabOrder = 3
        end
      end
      object GroupBox19: TGroupBox
        Left = 8
        Top = 316
        Width = 321
        Height = 132
        Caption = 'Query Tag'
        TabOrder = 1
        object SpeedButton_Query_6B: TSpeedButton
          Left = 208
          Top = 79
          Width = 102
          Height = 26
          AllowAllUp = True
          GroupIndex = 1
          Caption = 'Query by one'
          OnClick = Action_Query_6BExecute
        end
        object Label27: TLabel
          Left = 8
          Top = 30
          Width = 67
          Height = 13
          Caption = 'Read Interval:'
        end
        object ComboBox_IntervalTime_6B: TComboBox
          Left = 104
          Top = 25
          Width = 207
          Height = 21
          ItemHeight = 13
          TabOrder = 0
          OnChange = ComboBox_IntervalTime_6BChange
        end
        object Byone_6B: TRadioButton
          Left = 8
          Top = 70
          Width = 92
          Height = 17
          Caption = 'Query by one'
          TabOrder = 1
        end
        object Bycondition_6B: TRadioButton
          Left = 8
          Top = 98
          Width = 116
          Height = 17
          Caption = 'Query by Condition'
          TabOrder = 2
        end
      end
    end
  end
  object StatusBar1: TStatusBar
    Left = 0
    Top = 652
    Width = 828
    Height = 19
    AutoHint = True
    Panels = <
      item
        Width = 740
      end
      item
        Text = 'Port'
        Width = 66
      end
      item
        Text = 'Manufacturer name'
        Width = 100
      end>
  end
  object ActionList1: TActionList
    Left = 371
    Top = 2
    object Action_GetReaderInformation: TAction
      Tag = 1
      Category = #20018#21475#25171#24320#21363#21487#25191#34892'(TAG=1)'
      Caption = #33719#24471#35835#20889#22120#20449#24687
      OnExecute = Action_GetReaderInformationExecute
      OnUpdate = Action_GetReaderInformationUpdate
    end
    object Action_OpenCOM: TAction
      Category = #36890#35759
      Caption = #25171#24320#31471#21475
      OnExecute = Action_OpenCOMExecute
    end
    object Action_OpenRf: TAction
      Tag = 1
      Category = #20018#21475#25171#24320#21363#21487#25191#34892'(TAG=1)'
      Caption = #25171#24320#23556#39057
    end
    object Action_CloseCOM: TAction
      Category = #36890#35759
      Caption = #20851#38381#31471#21475
      OnExecute = Action_CloseCOMExecute
    end
    object Action_CloseRf: TAction
      Tag = 1
      Category = #20018#21475#25171#24320#21363#21487#25191#34892'(TAG=1)'
      Caption = #20851#38381#23556#39057
    end
    object Action_WriteComAdr: TAction
      Tag = 1
      Category = #20018#21475#25171#24320#21363#21487#25191#34892'(TAG=1)'
      Caption = #20889#20837#35835#20889#22120#22320#22336
    end
    object Action_WriteInventoryScanTime: TAction
      Tag = 1
      Category = #20018#21475#25171#24320#21363#21487#25191#34892'(TAG=1)'
      Caption = #20889#20837
      Hint = #20889#20837#35810#26597#21629#20196#26368#22823#21709#24212#26102#38388
    end
    object Action_OpenTestMode: TAction
      Category = #27979#35797#27169#24335
      Caption = #26597#35810#26631#31614
      OnExecute = Action_OpenTestModeExecute
    end
    object Action_CloseTestMode: TAction
      Category = #27979#35797#27169#24335
      Caption = #20851#38381#27979#35797#27169#24335
      OnExecute = Action_OpenTestModeExecute
    end
    object Action_GetSystemInformation: TAction
      Tag = 2
      Category = #21345#29255#25805#20316'(TAG=2)'
      Caption = #33719#21462#30005#23376#26631#31614#35814#32454#20449#24687
    end
    object Action_SetReaderInformation: TAction
      Category = #20018#21475#25171#24320#21363#21487#25191#34892'(TAG=1)'
      Caption = #35774#32622#21442#25968
      OnExecute = Action_SetReaderInformationExecute
    end
    object Action_SetReaderInformation_0: TAction
      Category = #20018#21475#25171#24320#21363#21487#25191#34892'(TAG=1)'
      Caption = #24674#22797#20986#21378#21442#25968
      OnExecute = Action_SetReaderInformationExecute
    end
    object Action_Inventory: TAction
      Category = #20018#21475#25171#24320#21363#21487#25191#34892'(TAG=1)'
      Caption = 'Action_Inventory'
      OnExecute = Action_InventoryExecute
    end
    object Action_ShowOrChangeData: TAction
      Category = #21345#29255#25805#20316'(TAG=2)'
      Caption = #35835
      OnExecute = Action_ShowOrChangeDataExecute
    end
    object Action_SetProtectState: TAction
      Category = #21345#29255#25805#20316'(TAG=2)'
      Caption = #35774#32622#20445#25252
      OnExecute = Action_SetProtectStateExecute
      OnUpdate = Action_SetProtectStateUpdate
    end
    object Action_DestroyCard: TAction
      Category = #21345#29255#25805#20316'(TAG=2)'
      Caption = #38144#27585
      OnExecute = Action_DestroyCardExecute
    end
    object Action_Inventroy_6B: TAction
      Category = '18000-6B'
      Caption = #26597#35810#26631#31614
    end
    object Action_Query_6B: TAction
      Category = '18000-6B'
      Caption = #26597#35810#26631#31614
      OnExecute = Action_Query_6BExecute
    end
    object Action_WriteData_6B: TAction
      Category = '18000-6B'
      Caption = #20889#25968#25454
    end
    object Action_ReadData_6B: TAction
      Category = '18000-6B'
      Caption = #35835#25968#25454
    end
    object Action_LockByte_6B: TAction
      Category = '18000-6B'
      Caption = #38145#23450
      OnExecute = Action_LockByte_6BExecute
    end
    object Action_CheckLock_6B: TAction
      Category = '18000-6B'
      Caption = #26816#27979#38145#23450
      OnExecute = Action_CheckLock_6BExecute
      OnUpdate = Action_CheckLock_6BUpdate
    end
    object Action_Query2_6B: TAction
      Category = '18000-6B'
      Caption = 'Action_Query2_6B'
    end
    object Action_ShowOrChangeData_write: TAction
      Category = #21345#29255#25805#20316'(TAG=2)'
      Caption = #20889
      OnExecute = Action_ShowOrChangeDataExecute
    end
    object Action_ShowOrChangeData_BlockErase: TAction
      Category = #21345#29255#25805#20316'(TAG=2)'
      Caption = #22359#25830#38500
      OnExecute = Action_ShowOrChangeDataExecute
    end
    object Action_SetReadProtect_G2: TAction
      Category = #21345#29255#25805#20316'(TAG=2)'
      Caption = #35774#32622#21333#24352#35835#20445#25252
      OnExecute = Action_SetReadProtect_G2Execute
    end
    object Action_RemoveReadProtect_G2: TAction
      Category = #21345#29255#25805#20316'(TAG=2)'
      Caption = #35299#38500#21333#24352#35835#20445#25252
      OnExecute = Action_RemoveReadProtect_G2Execute
    end
    object Action_SetMultiReadProtect_G2: TAction
      Category = #21345#29255#25805#20316'(TAG=2)'
      Caption = #35774#32622#22810#24352#35835#20445#25252
      OnExecute = Action_SetMultiReadProtect_G2Execute
    end
    object Action_CheckReadProtected_G2: TAction
      Category = #21345#29255#25805#20316'(TAG=2)'
      Caption = #26816#27979#21333#24352#34987#35835#20445#25252#65288#19981#38656#35201#21345#21495#23494#30721#65289'       '
      OnExecute = Action_CheckReadProtected_G2Execute
    end
    object Action_SetEASAlarm_G2: TAction
      Category = #21345#29255#25805#20316'(TAG=2)'
      Caption = #35774#32622
      OnExecute = Action_SetEASAlarm_G2Execute
    end
    object Action_CheckEASAlarm_G2: TAction
      Category = #21345#29255#25805#20316'(TAG=2)'
      Caption = #26816#27979
      OnExecute = Action_CheckEASAlarm_G2Execute
    end
    object Action_LockUserBlock_G2: TAction
      Category = #21345#29255#25805#20316'(TAG=2)'
      Caption = #38145#23450
      OnExecute = Action_LockUserBlock_G2Execute
    end
    object Action_WriteEPC_G2: TAction
      Category = #21345#29255#25805#20316'(TAG=2)'
      Caption = #20889'EPC'
      OnExecute = Action_WriteEPC_G2Execute
    end
  end
  object Timer_Test_: TTimer
    Enabled = False
    Interval = 50
    OnTimer = Timer_Test_Timer
    Left = 320
    Top = 2
  end
  object Timer_Test_6B: TTimer
    Enabled = False
    Interval = 50
    OnTimer = Timer_G2_Timer
    Left = 443
    Top = 2
  end
  object Timer_G2_Alarm: TTimer
    Interval = 200
    OnTimer = Timer_G2_AlarmTimer
    Left = 720
    Top = 2
  end
  object Timer_G2_Read: TTimer
    Enabled = False
    Interval = 200
    OnTimer = Timer_G2_ReadTimer
    Left = 83
    Top = 290
  end
  object Timer_6B_ReadWrite: TTimer
    Enabled = False
    Interval = 200
    OnTimer = Timer_6B_ReadWriteTimer
    Left = 787
    Top = 242
  end
end
