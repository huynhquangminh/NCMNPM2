import { Component, OnInit } from '@angular/core';
import { AppService } from 'src/app/service/app-service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { GET_LIST_BOOK_ROOM_URL, FIND_BOOK_ROOM_URL, DELETE_BOOK_ROOM_URL } from './config';
import { GetListOrderFromIdentitycardRequest } from 'src/app/model/find-booking-ticket.request';
import { DeleteBookRoomRequest } from '../../model/delete-book-room.model';
import { formatDate } from '@angular/common';

@Component({
  selector: 'app-listbookroom',
  templateUrl: './listbookroom.component.html',
  styleUrls: ['./listbookroom.component.css']
})
export class ListbookroomComponent implements OnInit {
  public addForm: FormGroup;
  listBookRoom: any;
  findRoomBookRequest = new GetListOrderFromIdentitycardRequest();
  deleteBookRoomRequest = new DeleteBookRoomRequest();
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

  btnCancel(value) {
    this.deleteBookRoomRequest.ID = value;
    this.appService.CallByResquestService(DELETE_BOOK_ROOM_URL, this.deleteBookRoomRequest).subscribe(data => {
      if (data) {
        if (data.Success === false) {
          alert('Your Request Is Unsuccessful');
        } else {
          this.GetListBookRoom();
        }
      }
    });
  }
  btnChangeBookRoom(data) {
    const ngayVao = formatDate(data.NgayVao, 'yyyy-MM-dd', 'en');
    const ngayRa = formatDate(data.NgayVao, 'yyyy-MM-dd', 'en');
    this.router.navigate(['/home/update-book-room',
    { isbook: 'true', id: data.ID, sophong: data.SoPhong, ngayvao: ngayVao, ngayra: ngayRa, cmnd: data.CMND, tenkh: data.TenKhachHang }]);
  }

}
