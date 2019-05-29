import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdatebookroomComponent } from './updatebookroom.component';

describe('UpdatebookroomComponent', () => {
  let component: UpdatebookroomComponent;
  let fixture: ComponentFixture<UpdatebookroomComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UpdatebookroomComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdatebookroomComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
