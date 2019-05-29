import { Component, OnInit } from '@angular/core';
import { AppService } from 'src/app/service/app-service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { GET_LIST_BOOK_ROOM_URL, FIND_BOOK_ROOM_URL } from './config';
import { GetListOrderFromIdentitycardRequest } from 'src/app/model/find-booking-ticket.request';

@Component({
  selector: 'app-listbookroom',
  templateUrl: './listbookroom.component.html',
  styleUrls: ['./listbookroom.component.css']
})
export class ListbookroomComponent implements OnInit {
  public addForm: FormGroup;
  listBookRoom: any;
  findRoomBookRequest = new GetListOrderFromIdentitycardRequest();
  isThongbao = false;
  keycmnd = '';
  constructor(private appService: AppService, private formBuilder: FormBuilder, private router: Router) {
    this.addForm = this.formBuilder.group({
      CMND: [, [Validators.required]],
    });
  }

  ngOnInit() {
    this.GetListBookRoom();
  }

  GetListBookRoom() {
    this.appService.CallAllService(GET_LIST_BOOK_ROOM_URL).subscribe(data => {
      if (data) {
        if (data.Success === false) {
          alert('Your Request Is Unsuccessful');
        } else {
          this.listBookRoom = data.ListBookRoomp;
        }
      }
    });
  }
  searchBookRoom(value) {
    this.findRoomBookRequest.CMND = value;
    this.appService.CallByResquestService(FIND_BOOK_ROOM_URL, this.findRoomBookRequest).subscribe(data => {
      if (data) {
        if (data.Success === false) {
          alert('Your Request Is Unsuccessful');
        } else {
          this.listBookRoom = data.ListBookRoomp;
          if (this.listBookRoom.length === 0) {
            this.isThongbao = true;
          } else {
            this.isThongbao = false;
          }
        }
      }
    });
  }

}
