unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, db, sqldb, sqlite3conn, mysql40conn, odbcconn, Forms,
  Controls, Graphics, Dialogs, StdCtrls, ExtCtrls, DBGrids;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    DataSource1: TDataSource;
    DBGrid1: TDBGrid;
    Image1: TImage;
    Label1: TLabel;
    Shape1: TShape;
    SQLConnector1: TSQLConnector;
    SQLQuery1: TSQLQuery;
    SQLTransaction1: TSQLTransaction;
    procedure Button1Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure Shape1ChangeBounds(Sender: TObject);
  private

  public

  end;

var
  Form1: TForm1;

implementation

{$R *.lfm}

{ TForm1 }

procedure TForm1.Button1Click(Sender: TObject);
begin

end;

procedure TForm1.Button3Click(Sender: TObject);
begin

end;

procedure TForm1.Button4Click(Sender: TObject);
begin

end;

procedure TForm1.Shape1ChangeBounds(Sender: TObject);
begin

end;

end.

