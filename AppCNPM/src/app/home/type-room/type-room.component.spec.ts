import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TypeRoomComponent } from './type-room.component';

describe('TypeRoomComponent', () => {
  let component: TypeRoomComponent;
  let fixture: ComponentFixture<TypeRoomComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TypeRoomComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TypeRoomComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
