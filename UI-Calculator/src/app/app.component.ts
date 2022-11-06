import { Component } from '@angular/core';
import { CalculatorService } from 'src/services/calculator.service';
import { Request } from '../models/request.model';
import { Response } from '../models/response.model';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'UI-Calculator';
  operator: string = "";
  response: Response = new Response();
  error:  string = "";

  constructor(private _calculatorService: CalculatorService){}

  operatorChange(operator:string){
    this.operator = operator;
  }

  calculate(numberOne:string,numberTwo:string){
    //Allows only dot(.)
    let request = new Request();
    request.valuesBasicOperations.push(Number(numberOne));
    request.valuesBasicOperations.push(Number(numberTwo));
    this.postBasicOperation(request);
  }

  postBasicOperation(request: Request){
      this._calculatorService.postBasicOperation(request, this.operator)
      .subscribe((data:Response) => {
                    this.response = data,
                    this.error = ""},
                  error => {
                    this.error = error}
        )
  }
}


