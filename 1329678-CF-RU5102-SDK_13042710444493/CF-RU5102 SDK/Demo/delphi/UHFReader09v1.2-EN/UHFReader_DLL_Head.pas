unit UHFReader_DLL_Head;

interface

Const

    UHFReader_DLLName = 'UHFReader09.dll'; // 'RR9000EXT.DLL'

type
    RTempRecord=Record
    end;
    //==========================================================================================//
    Function OpenComPort(Port : LongInt;var ComAdr : byte;Baud:byte; var frmcomportindex: longint): LongInt; stdcall; external UHFReader_DLLName ;
    Function CloseComPort(  ): LongInt; stdcall;external UHFReader_DLLName ;
    Function AutoOpenComPort(var Port : longint; var ComAdr : byte;Baud:byte; var frmComPortindex :longint ) : LongInt; stdcall; external UHFReader_DLLName ;
    Function CloseSpecComPort( frmComPortindex : longint ): LongInt; stdcall;external UHFReader_DLLName ;
    Function GetReaderInformation(var ComAdr: byte; VersionInfo: pchar;
                                  var ReaderType: byte; TrType: pchar;
                                  var dmaxfre ,dminfre,powerdBm:Byte;
                                  var ScanTime: byte;
                                  frmComPortindex : longint): LongInt; stdcall; external UHFReader_DLLName ;
    Function WriteComAdr(var ComAdr : byte; var ComAdrData : Byte; frmComPortindex : longint): LongInt; stdcall; external UHFReader_DLLName ;
    Function SetPowerDbm(var ComAdr : byte;powerDbm : Byte; frmComPortindex : longint): LongInt; stdcall; external UHFReader_DLLName ;
    Function Writedfre(var ComAdr : byte;var dmaxfre : Byte; var dminfre : Byte;frmComPortindex : longint): LongInt; stdcall; external UHFReader_DLLName ;
    Function Writebaud(var ComAdr : byte;var baud : Byte; frmComPortindex : longint): LongInt; stdcall; external UHFReader_DLLName ;
    Function WriteScanTime(var ComAdr : byte;var ScanTime : Byte; frmComPortindex : longint): LongInt; stdcall;external UHFReader_DLLName ;
//EPC  G2
    Function Inventory_G2(var ComAdr : byte;EPClenandEPC : pchar; var Totallen:longint;var CardNum : LongInt;frmComPortindex:LongInt): LongInt; stdcall; external UHFReader_DLLName ;

    Function ReadCard_G2(var ComAdr;EPC:PChar;Mem,WordPtr,Num:Byte;
                    Password:PChar;maskadr,maskLen,maskFlag:Byte;Data:PChar;EPClength:byte;var errorcode:longint;frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
    Function WriteCard_G2(var ComAdr;EPC:PChar;Mem,WordPtr,Writedatalen:Byte;Writedata:PChar;
                    Password:PChar;maskadr,maskLen,maskFlag:Byte;WrittenDataNum:LongInt;EPClength:byte;var errorcode:longint;
                    frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
    Function EraseCard_G2(var ComAdr;EPC:PChar;Mem,WordPtr,Num:Byte;
                    Password:PChar;maskadr,maskLen,maskFlag:Byte;EPClength:byte;var errorcode:longint;frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
    Function SetCardProtect_G2(var ComAdr;EPC:PChar;select,setprotect:Byte;
                    Password:PChar;maskadr,maskLen,maskFlag:Byte;EPClength:byte;var errorcode:longint;frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
    Function DestroyCard_G2(var ComAdr;EPC:PChar;
                    Password:PChar;maskadr,maskLen,maskFlag:Byte;EPClength:byte;var errorcode:longint;frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
    Function WriteEPC_G2(var ComAdr;
                    Password:PChar;WriteEPC:PChar;WriteEPClen:byte;var errorcode:longint;frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
    Function SetReadProtect_G2(var ComAdr;EPC:PChar;
                    Password:PChar;maskadr,maskLen,maskFlag:Byte;EPClength:byte;var errorcode:longint;frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
    Function SetMultiReadProtect_G2(var ComAdr;
                    Password:PChar;var errorcode:longint;frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
    Function RemoveReadProtect_G2(var ComAdr;
                    Password:PChar;var errorcode:longint;frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
    Function CheckReadProtected_G2(var ComAdr; var readpro:byte;
                    var errorcode:longint;frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
    Function SetEASAlarm_G2(var ComAdr;EPC:PChar;
                    Password:PChar;maskadr,maskLen,maskFlag:Byte;EAS:byte;EPClength:byte;var errorcode:longint;frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
    Function CheckEASAlarm_G2(var ComAdr;
                    var errorcode:longint;frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
    Function LockUserBlock_G2(var ComAdr;EPC:PChar;
                    Password:PChar;maskadr,maskLen,maskFlag:Byte;BlockNum:byte;EPClength:byte;var errorcode:longint;frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
    Function WriteBlock_G2(var ComAdr;EPC:PChar;Mem,WordPtr,Writedatalen:Byte;Writedata:PChar;
                    Password:PChar;maskadr,maskLen,maskFlag:Byte;WrittenDataNum:LongInt;EPClength:byte;var errorcode:longint;
                    frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;

//18000_6B

  Function Inventory_6B(var ComAdr : byte; ID_6B : pchar;frmComPortindex:LongInt): LongInt; stdcall; external UHFReader_DLLName ;
  Function inventory2_6B(var ComAdr : byte;Condition,StartAddress,mask:byte;ConditionContent:PChar; ID_6B : pchar;var Cardnum:LongInt;frmComPortindex:LongInt): LongInt; stdcall; external UHFReader_DLLName ;
  Function ReadCard_6B(var ComAdr;ID_6B:PChar;StartAddress,Num:Byte;
                      Data:PChar;var errorcode:longint;frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
  Function WriteCard_6B(var ComAdr;ID_6B:PChar;StartAddress:Byte;Writedata:PChar;Writedatalen:Byte;var writtenbyte:longint;var errorcode:longint;
                  frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
  Function LockByte_6B(var ComAdr;ID_6B:PChar;Address:Byte;var errorcode:longint;
                  frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;
  Function CheckLock_6B(var ComAdr;ID_6B:PChar;Address:Byte;var ReLockState:Byte;var errorcode:longint;
                  frmComPortindex : longint ): LongInt;stdcall;external UHFReader_DLLName ;


implementation


end.












 
