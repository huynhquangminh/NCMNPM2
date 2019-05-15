import { Component, OnInit } from '@angular/core';
import { AppService } from 'src/app/service/app-service';
import { GETPSERVICEALL_UTL } from './config';

@Component({
  selector: 'app-type-service',
  templateUrl: './type-service.component.html',
  styleUrls: ['./type-service.component.css']
})
export class TypeServiceComponent implements OnInit {
  urlImage = 'http://localhost:3100/image/';
  listService: any;
  constructor(private service: AppService) { }

  ngOnInit() {
    this.callService();
  }

  callService() {
    this.service.CallAllService(GETPSERVICEALL_UTL).subscribe(
      data => {
        if (data) {
          if (data.Success === false) {
            alert('Your Request Is Unsuccessful');
          } else {
            this.listService = data.ListServiceAll;
          }
        }
      });
  }

}
