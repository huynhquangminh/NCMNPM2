import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  urlImage = 'http://localhost:3100/image/';
  content = 'Vivamus sagittis lacus vel augue laoreet rutrum faucibus.';
  ctForm: FormGroup;
  constructor(private fb: FormBuilder) {
    this.ctForm = this.fb.group({
      userName: [null, [Validators.required]],
      email: [null, [Validators.required, Validators.email]],
      content: [null, [Validators.required]],
    });
  }

  ngOnInit() {
  }

  sendMSM() {

  }
}
