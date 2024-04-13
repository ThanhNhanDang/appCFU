program UHFReader09demo_en;

{%File 'History.txt'}

uses
  Forms,
  UHFReader_DLL_Head in 'UHFReader_DLL_Head.pas',
  UHFReader_Head in 'UHFReader_Head.pas',
  fUHFReaderdemomain in 'fUHFReaderdemomain.pas' {frmUHFReaderdemomain},
  fUHFProgress in 'fUHFProgress.pas' {frmUHFProgress};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TfrmUHFReaderdemomain, frmUHFReaderdemomain);
  Application.CreateForm(TfrmUHFProgress, frmUHFProgress);
  Application.Run;
end.
