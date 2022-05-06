import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(private http:HttpClient)
  {
  }
  title = 'angular';
  display1='';
  display2='';
  
  public outputs:string[]=[];
  public dataInputOutput=[
    {
      in:'Kiểu dữ liệu đầu vào',out:['Kiểu dữ liệu đầu ra']
    },
    {
      in:'String',out:['Hex','Base64','Byte']
    },
    {
      in:'Hex',out:['String','Base64','Byte']
    },
    {
      in:'Base64',out:['Hex','String','Byte']
    },
    {
      in:'Byte',out:['Hex','String','Base64']
    },

  ];

  input2: any;
  output2:any;


public onEncode(event:any)
{
  console.log('input',event.target.value);
  this.input2=event.target.value;
  if(!this.input2)
  {
    return;
  }
  const search=this.dataInputOutput.filter((data)=>data.in===this.input2);
  console.log('search',search);
  if(search&&search.length>0)
  {
    this.outputs=search[0].out;
  }
}

public onDecode(event:any)
{
 console.log('output',event.target.value);
  this.output2=event.target.value;
}

public onSubmit(event:any)
{
  this.http.post('https://localhost:44323/api/Home/EncodeToByte?request='+event.inputValue+'&inputData='+this.input2,
  null,{responseType:'text'})
  .subscribe((res)=>  
  {
    this.display1=res;
    console.log('display1: ',this.display1)
  });
 
  return this.http.post('https://localhost:44323/api/Home/DecodeToData?request='+this.display1 +'&outputData='+this.output2,
    null,{responseType:'text'})
    .subscribe((res)=>  
    {
      this.display2=res;
      console.log('display2: ',this.display2)
    });
}
}

