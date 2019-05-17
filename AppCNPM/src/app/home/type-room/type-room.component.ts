import { Component, OnInit } from '@angular/core';
import { AppService } from 'src/app/service/app-service';
import { GETPROOMALL_UTL } from './config';

@Component({
  selector: 'app-type-room',
  templateUrl: './type-room.component.html',
  styleUrls: ['./type-room.component.css']
})
export class TypeRoomComponent implements OnInit {
  urlImage = 'http://localhost:3100/image/';
  listRoom: any;
  constructor(private service: AppService) { }

  ngOnInit() {
    this.callService();
  }

  callService() {
    this.service.CallAllService(GETPROOMALL_UTL).subscribe(
      data => {
        if (data) {
          if (data.Success === false) {
            alert('Your Request Is Unsuccessful');
          } else {
            this.listRoom = data.ListRoom;
          }
        }
      });
  }
}
