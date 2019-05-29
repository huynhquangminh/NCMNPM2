import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditbookroomComponent } from './editbookroom.component';

describe('EditbookroomComponent', () => {
  let component: EditbookroomComponent;
  let fixture: ComponentFixture<EditbookroomComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditbookroomComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditbookroomComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
