import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListbookroomComponent } from './listbookroom.component';

describe('ListbookroomComponent', () => {
  let component: ListbookroomComponent;
  let fixture: ComponentFixture<ListbookroomComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListbookroomComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListbookroomComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
