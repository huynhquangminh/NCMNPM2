import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { formatDate } from '@angular/common';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {
  public addForm: FormGroup;
  constructor(private formBuilder: FormBuilder) {
    this.addForm = this.formBuilder.group({
      DateStart: [formatDate(new Date(), 'yyyy-MM-dd', 'en'), [Validators.required]],
      DateEnd: [formatDate(new Date(), 'yyyy-MM-dd', 'en'), [Validators.required]],

    });
  }

  ngOnInit() {
  }

  OnBookNow() {
    if (this.addForm.get('DateStart').value >= this.addForm.get('DateEnd').value
      || this.addForm.get('DateStart').value < formatDate(new Date(), 'yyyy-MM-dd', 'en')) {
      alert('Ngày Bắt đầu phải nhỏ hơn ngày kết thúc và lớn hơn ngày hiện tại ');
    }
  }
}
