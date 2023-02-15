#pragma once

class Widget {
  private:
    bool enabled;
  public:
    virtual ~Widget();
    void enable();
    void disable();
    virtual void draw();
};
